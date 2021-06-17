using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCentral : MonoBehaviour {


    public void Jogar() {

      SceneManager.LoadScene(2);
      
    }

    public void HighScores() {

      SceneManager.LoadScene(1);
      
    }

    public void Menu() {

      SceneManager.LoadScene(0);
      
    }



}
