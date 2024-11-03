using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Chef")]
<<<<<<< HEAD

    public ShopButton chefButton;

    public int chefPrice = 10;

    public int chefCount = 0;

    public int clicks = 0;


    private Clicker clicker;

    private void Start()
=======
    public ShopButton chefButton;
    public int chefPrice = 10;
    public int chefCount = 0;

    private Clicker clicker;

    private void Start() 
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27
    {
        clicker = FindObjectOfType<Clicker>();
        chefButton.UpdateText(chefPrice, chefCount);
    }

    public void BuyChef()
    {
        if (clicker.clicks >= chefPrice)
        {
            clicker.clicks -= chefPrice;
            UiManager.instance.UpdateClicks(clicker.clicks);
<<<<<<< HEAD

            chefCount++;
            chefPrice = Mathf.RoundToInt(chefPrice * 1.5f);
=======
            
            chefCount++;
            chefPrice = Mathf.RoundToInt(chefPrice * 1.5f);//increase price by 15%
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27
            chefButton.UpdateText(chefPrice, chefCount);
        }
    }
}
