using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstilingueInv : MonoBehaviour
{

    private MunicaoInv MncInv;
    public GameObject Pedra;

    // Start is called before the first frame update
    void Start()
    {
        MncInv = GameObject.Find("Player").GetComponent<MunicaoInv>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DispararPedra()
    {
        if (Input.GetKeyDown("o"))
        {
            Instantiate(Pedra, transform.position, Quaternion.identity);
        }
    }
}
