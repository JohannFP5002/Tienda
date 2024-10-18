using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonShop : MonoBehaviour
{
    [SerializeField]
    string[] posiblesNombres;
    [SerializeField]
    Cartera saldo;
    [SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;
    // Start is called before the first frame update
    void Start()
    {
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(250f, 450f);
        textButton.text = nameItem + "\n" + priceItem.ToString() + " €";


    }
    public void ClickEnBotonDeTienda()
    {
        saldo.RestarSaldo(nameItem, priceItem);
    }
}
