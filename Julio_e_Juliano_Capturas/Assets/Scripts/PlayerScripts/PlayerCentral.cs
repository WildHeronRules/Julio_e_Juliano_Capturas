using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCentral : MonoBehaviour
{
    
    public int Points;
    public float Stamina;
    

    public Text staminaUI;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       staminaUI.text = "Energia: " + Stamina;
    }
}
