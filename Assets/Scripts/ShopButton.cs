<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public TextMeshProUGUI priceText;
<<<<<<< HEAD

=======
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27
    public TextMeshProUGUI countText;


    public void UpdateText(int price, int count)
    {
        priceText.text = $"price: {price}";
        countText.text = count.ToString();
    }
}
