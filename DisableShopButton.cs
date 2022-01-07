using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableShopButton : MonoBehaviour
{
    public Button ShopButton;

    public void disableVioletsButton() {
        if (DisplayItems.Violets == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableCupcakesButton() {
        if (DisplayItems.Cupcakes == true) {
            ShopButton.interactable = false;
        }
    }

    public void disablePictureframeButton() {
        if (DisplayItems.Frame == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableVanderGauntletsButton() {
        if (DisplayItems.Gauntlets == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableGun() {
        if (DisplayItems.Gun == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableBunny() {
        if (DisplayItems.Bunny == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableJinx() {
        if (DisplayItems.Jinx == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableRealCupcake() {
        if (DisplayItems.Cait == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableChair() {
        if (DisplayItems.Chair == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableMonkey() {
        if (DisplayItems.Monkey == true) {
            ShopButton.interactable = false;
        }
    }

    public void disabletwoForOne() {
        if (DisplayItems.twoForOne == true) {
            ShopButton.interactable = false;
        }
    }

    public void disablevi6() {
        if (DisplayItems.vi6 == true) {
            ShopButton.interactable = false;
        }
    }

    public void disablefiveOneSix() {
        if (DisplayItems.fiveOneSix == true) {
            ShopButton.interactable = false;
        }
    }
    public void disabletenHit() {
        if (DisplayItems.tenHit == true) {
            ShopButton.interactable = false;
        }
    }

    public void disablesixForOne() {
        if (DisplayItems.sixForOne == true) {
            ShopButton.interactable = false;
        }
    }

    public void disableDentingBlows() {
        if (DisplayItems.DentingBlows == true) {
            ShopButton.interactable = false;
        }
    }

    
}
