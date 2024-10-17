using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cartera : MonoBehaviour
{
    
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;
    [SerializeField]
    GameObject ConfirmarCompra;
    [SerializeField]
    GameObject NoTienesSaldo;

    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f,950f);
        labelSaldo.text = saldo.ToString("000.00") + "€";
    }

    public void RestarSaldo(float precio)
    {
        if (saldo > precio)
        {
            saldo -= precio;
            labelSaldo.text = saldo.ToString("000.00") + " €";
        }
        else
        {
            NoTienesSaldo.SetActive(true);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
