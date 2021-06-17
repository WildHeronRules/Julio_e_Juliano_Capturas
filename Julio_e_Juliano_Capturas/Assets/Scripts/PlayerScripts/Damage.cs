using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    private EnemyCentral eCentral;

    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag.Equals("EnemyAttack")){
            eCentral.eLife -= 1;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        eCentral = GameObject.Find("Enemy").GetComponent<EnemyCentral>();
    }


}
