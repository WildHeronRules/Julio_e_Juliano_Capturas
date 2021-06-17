using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCentral : MonoBehaviour
{
    
    public int Points;
    public float Stamina;
    

    public Text staminaUI;
    private EnemyCentral eCentral;
    

    void Awake()
    {
        eCentral = GameObject.Find("Enemy").GetComponent<EnemyCentral>();
    }

    // Update is called once per frame
    void Update()
    {
       if(eCentral.eLife <= 0){
           
           SceneManager.LoadScene(3);

       } 

       staminaUI.text = "Energia: " + Stamina;
    }
}
