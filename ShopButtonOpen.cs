using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonOpen : MonoBehaviour
{
    public GameObject shopPanel;

    public void OpenShop() {
        if (shopPanel != null) {
            shopPanel.SetActive(true);
        }
    }

    public void CloseShop() {
        if (shopPanel) {
            shopPanel.SetActive(false);
        }
    }
}
