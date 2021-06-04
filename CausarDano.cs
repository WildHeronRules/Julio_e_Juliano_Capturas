using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CausarDano : MonoBehaviour
{

    public Inimigo enemy;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name == "Inimigo"){
            enemy.HP += (-10);
            Debug.Log("Bateu");
        }

    }
}
