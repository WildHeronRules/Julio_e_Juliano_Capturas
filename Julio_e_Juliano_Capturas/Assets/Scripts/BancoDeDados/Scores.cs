using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public Text[] NomesJogadores;
    public Text[] PontosJogadores;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(listarJogadores());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VoltarBtn()
    {

    }

    IEnumerator listarJogadores()
    {
        WWWForm wwwf = new WWWForm();
        wwwf.AddField("limite", 10);

        UnityWebRequest w = UnityWebRequest.Post("http://localhost/jejc_bd/listarJogadores.php", wwwf);

        yield return w.SendWebRequest();

        if (w.isHttpError || w.isNetworkError)
        {
            Debug.Log("Erro: " + w.error);
        }
        else
        {
            Pontuacao pontuacaoContainer = JsonUtility.FromJson<Pontuacao>(w.downloadHandler.text);

            for (int i = 0; i < pontuacaoContainer.objetos.Length; i++)
            {
                NomesJogadores[i].text = pontuacaoContainer.objetos[i].jogador;
                PontosJogadores[i].text = pontuacaoContainer.objetos[i].pontos.ToString();
            }
        }
    }
}
