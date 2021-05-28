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


    private void Awake(){

        m_input = new PlayerInputs();

        m_input.Player.Interact.performed += ctx => InteractDone();
        m_input.Player.Interact.canceled += ctx => InteractFinish();
    }

    public void InteractDone(){
        Interaction = true;
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

        
        if(col.gameObject.tag.Equals("Item")){
            pick = true;
        }


    }

    private void OnTriggerStay2D(Collider2D col){

        if(destruct){
            Destroy(col.gameObject);
            destruct = false;
        }

    }

    private void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag.Equals("Item")){
            pick = false;
        }
    }



}
