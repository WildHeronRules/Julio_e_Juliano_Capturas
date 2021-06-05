using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

     public int HP;
     public GameObject CorpEnemy; 

    // Start is called before the first frame update
    void Start()
    {
        HP =+ 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0){
           Object.Destroy(CorpEnemy);
        }
    }
}
