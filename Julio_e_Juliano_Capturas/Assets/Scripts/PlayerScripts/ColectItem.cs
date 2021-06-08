using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColectItem : MonoBehaviour
{


    private PlayerInputs m_input;

    [SerializeField]
    private bool pick;
    [SerializeField]
    private bool Interaction = false;

    [SerializeField]
    private bool destruct = false;

    private PlayerCentral pCentral;


    private void Awake(){


        pCentral = this.gameObject.GetComponent<PlayerCentral>();
        m_input = new PlayerInputs();

        m_input.Player.Interact.performed += ctx => InteractDone();
        m_input.Player.Interact.canceled += ctx => InteractFinish();
    }

    public void InteractDone(){
        if(pick == true){
        Interaction = true;
        Invoke("InteractFinish", 0.3f);
        }
    }

    public void InteractFinish(){
        Interaction = false;
    }

    private void OnEnable(){

        m_input.Enable();

    }

    private void OnDisable(){
       
        m_input.Disable();

    }

    private void Update(){
        if(pick && Interaction){

            destruct = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col){

        
        if(col.gameObject.tag.Equals("Item") || col.gameObject.tag.Equals("PItems")){
            pick = true;
        }

        if(col.gameObject.tag.Equals("PItems")){

            pick = true;
        }
        

        void Destruction(){
            Destroy(col.gameObject);
        }

        if(destruct && col.gameObject.tag.Equals("Item")){
            Destruction();
            destruct = false;
        }

        if(destruct && col.gameObject.tag.Equals("PItems")){
            PointItems pts = col.gameObject.GetComponent<PointItems>();

            pCentral.Points += pts.value;
            
            Destruction();
            destruct = false;
        }

    }

    private void OnTriggerStay2D(Collider2D col){

        void Destruction(){
            Destroy(col.gameObject);
        }

        if(destruct && col.gameObject.tag.Equals("Item")){
            Destruction();
            destruct = false;
        }

        if(destruct && col.gameObject.tag.Equals("PItems")){
            PointItems pts = col.gameObject.GetComponent<PointItems>();

            pCentral.Points += pts.value;
            
            Destruction();
            destruct = false;
        }

    }

        

    private void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag.Equals("Item") || col.gameObject.tag.Equals("PItems")){
            pick = false;
        }

    }



}
