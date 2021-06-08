using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject atkL;
    public GameObject atkR;
    public GameObject atkD;
    public GameObject atkU;

    public PlayerMovement pMove;

    private PlayerInputs m_input;
    // Start is called before the first frame update
    void Start()
    {
        pMove = this.gameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake(){


        
        m_input = new PlayerInputs();

        m_input.Player.Attack.started += ctx => AttackStart();
        m_input.Player.Attack.canceled += ctx => AttackFinish();
        
    }
    public void AttackStart (){

        if(pMove.lastPos[0] == 1){
           atkR.SetActive(true);
           Invoke("AttackFinish", 0.3f);
        }
        else if(pMove.lastPos[0] == -1){
           atkL.SetActive(true);
           Invoke("AttackFinish", 0.3f);
        }

        if(pMove.lastPos[1] == 1){
            atkU.SetActive(true);
            Invoke("AttackFinish", 0.3f);
        }
        else if(pMove.lastPos[1] == -1){
            atkD.SetActive(true);
            Invoke("AttackFinish", 0.3f);
        }

    }

     public void AttackFinish (){
        atkR.SetActive(false);
        atkL.SetActive(false);
        atkU.SetActive(false);
        atkD.SetActive(false);
    }

    private void OnEnable(){

        m_input.Enable();

    }

    private void OnDisable(){
       
        m_input.Disable();

    }
}
