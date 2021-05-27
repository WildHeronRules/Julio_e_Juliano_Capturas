using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarEstilingue : MonoBehaviour
{

    public GameObject pedra;
    private AtirarPedra AtPd;

    // Start is called before the first frame update
    void Start()
    {
        AtPd = GameObject.Find("ATIRAR PEDRA").GetComponent<AtirarPedra>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void dispararParaCima()
    {
        AtPd.speedX = 0;
        AtPd.speedY = 5;
        Instantiate(pedra, transform.position, Quaternion.identity);
    }

    void dispararParaBaixo()
    {
        AtPd.speedX = 0;
        AtPd.speedY = -5;
        Instantiate(pedra, transform.position, Quaternion.identity);
    }

    void dispararParaDireita()
    {
        AtPd.speedX = 5;
        AtPd.speedY = 0;
        Instantiate(pedra, transform.position, Quaternion.identity);
    }

    void dispararParaEsquerda()
    {
        AtPd.speedX = -5;
        AtPd.speedY = 0;
        Instantiate(pedra, transform.position, Quaternion.identity);
    }
}
