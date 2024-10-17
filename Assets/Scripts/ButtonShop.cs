using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonShop : MonoBehaviour
{

    [SerializeField]
    Cartera Wallet;
    [SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;
    // Start is called before the first frame update
    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(250f, 450f);
        textButton.text = priceItem.ToString() + " €";

    }
    public void ClickEnBotonDeTienda()
    {
        Wallet.RestarSaldo(priceItem);
    }
    
    void Update()
    {
        
    }
}
