using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag.Equals("Player")){
            SceneManager.LoadScene(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
