using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PtsTeste : MonoBehaviour
{
    public int pontos = 0;
    public Text pontuacao;
    public Button Add;
    public Button Remove;
    public Button Salvar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = "Sua pontuação: " + pontos;
        PlayerPrefs.SetInt("Pontuacao", pontos);
    }

    public void AddBtn()
    {
        pontos++;
    }

    public void RemoveBtn()
    {
        pontos--;
    }

    public void AcabarBtn()
    {
        //mudar para a cena "Controles"
        SceneManager.LoadScene("SaveScore");
    }
}
