using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{

    private PlayerCentral pCentral;

    private void Awake(){
       
        pCentral = GameObject.Find("Player").GetComponent<PlayerCentral>();

    }


    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag.Equals("EnemyAttack")){
            Destroy(gameObject);
            pCentral.Points -= 5;
        }
    }
}
