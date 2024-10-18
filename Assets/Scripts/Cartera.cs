using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cartera : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI labelConfirmacion;
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;
    [SerializeField]
    GameObject ConfirmarCompra;
    [SerializeField]
    GameObject NoTienesSaldo;

    float PrecioObjetoComprado;

    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f,950f);
        labelSaldo.text = saldo.ToString("000.00") + "€";
    }

    public void RestarSaldo(string nameItem, float precio)
    {
        if (saldo > precio)
        {
            ConfirmarCompra.SetActive(true);
            saldo -= precio;
            PrecioObjetoComprado = precio;
        }
        else
        {
            NoTienesSaldo.SetActive(true);
        }
    }
    public void ConfirmarLaCompra()
    {
        if (saldo > PrecioObjetoComprado)
        {
            saldo = saldo - PrecioObjetoComprado;
            PrecioObjetoComprado = 0.0f;
            ConfirmarCompra.SetActive(false);
            labelSaldo.text = saldo.ToString("000.00") + "€";
        }
        else
        {
            ConfirmarCompra.SetActive(false);
            NoTienesSaldo.SetActive(true);
        }
    }
}
