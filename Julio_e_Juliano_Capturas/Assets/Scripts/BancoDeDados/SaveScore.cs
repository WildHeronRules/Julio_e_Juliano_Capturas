using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SaveScore : MonoBehaviour
{
    public Text pontuacao;
    public Text status;
    public InputField nome;
    public Button salvar;

    public int pontos;
    public string jogador;

    void Start()
    {
        pontuacao.text = "Você fez " + PlayerPrefs.GetInt("Pontuacao") + " pontos";
        pontos = PlayerPrefs.GetInt("Pontuacao");
    }

    void Update()
    {
        jogador = nome.text;
        pontos = PlayerPrefs.GetInt("Pontuacao");
    }

    public void SalvarBtn()
    {
        if (nome.text != "")
        {
            StartCoroutine(AdicionarPontuacao());
            status.text = "Registrando pontuacao";
            salvar.enabled = false;
            nome.enabled = false;
            PlayerPrefs.SetInt("Pontuacao", 0);
        }
        else
        {
            status.text = "Escreva um nome primeiro";
        }
    }

    IEnumerator AdicionarPontuacao()
    {
        WWWForm wwwf = new WWWForm();
        wwwf.AddField("jogador", jogador);
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
                status.text = "Sua pontuacao foi salva";
            }
        }
    }
}
