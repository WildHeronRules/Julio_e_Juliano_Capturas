using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SaveScore : MonoBehaviour
{

    public Text pontuacao;
    public InputField nome;

    public int pontos = PlayerPrefs.GetInt("Pontos");

    void Start()
    {
        nome.Text = "Sua pontuacao final: " + PlayerPrefs.GetInt("Pontos");
    }

    void Update()
    {
        
    }

    public void InserirPontuacao()
    {
        StartCoroutine(AdicionarPontuacao(nome.Text));
    }

    IEnumerator AdicionarPontuacao(string Nome)
    {
        WWWForm wwwf = new WWWForm();
        wwwf.AddField("jogador", Nome);
        wwwf.AddField("pontos", pontos);

        UnityWebRequest w = UnityWebRequest.Post("http://localhost/jejc_bd/inserirPontuacao.php", wwwf);

        yield return w.SendWebRequest();

        if (w.isHttpError || w.isNetworkError)
        {
            Debug.Log("Erro: " + w.error);
        }
        else
        {
            if (w.downloadHandler.text.Equals("Ok"))
            {
                Desistir.enabled = true;
                SoVai.enabled = true;

                txtMsg.text = "Sua pontuação foi salva";
            }
            else if (w.downloadHandler.text.Equals("Pontuacao menor, mas Ok"))
            {
                Desistir.enabled = true;
                SoVai.enabled = true;

                txtMsg.text = "Nem salvei hein, faça melhor...";
            }
        }
    }
}
