using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{

    private PlayerInputs m_input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake(){


        
        m_input = new PlayerInputs();

        m_input.Player.Attack.performed += ctx => AttackDone();
        m_input.Player.Attack.canceled += ctx => AttackFinish();
        
    }
    public void AttackDone (){

    }

     public void AttackFinish (){
        
    }

    private void OnEnable(){

        m_input.Enable();

    }

    private void OnDisable(){
       
        m_input.Disable();

    }

    
}
