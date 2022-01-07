using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtons : MonoBehaviour
{
    public GameObject ScrollView;
    public GameObject Button;
    public GameObject Button2;
    public GameObject Button3;

    public void OpenMiniShop() {
        if (ScrollView != null) {
            ScrollView.SetActive(true);
            Button.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(true);
        }
    }

    public void CloseMiniShop() {
        if (ScrollView) {
            ScrollView.SetActive(false);
            Button.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(false);
        }
    }

}
