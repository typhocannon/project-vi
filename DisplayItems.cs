using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItems : MonoBehaviour
{
    public GameObject shopItem;
    public static bool Gun = false; 
    public static bool Violets = false;
    public static bool Frame = false;
    public static bool Gauntlets = false;
    public static bool Cupcakes = false;
    public static bool Bunny = false;
    public static bool Jinx = false; 
    public static bool Cait = false;
    public static bool Chair = false;
    public static bool Monkey = false; 
    
    public static bool twoForOne = false;
    public static bool vi6 = false;
    public static bool fiveOneSix = false;
    public static bool tenHit = false;
    public static bool sixForOne = false;
    public static bool DentingBlows = false;

    public void displayGun() {
        if (shopItem != null && GlobalCookies.CookieCount >= 375) {
            shopItem.SetActive(true);
            Gun = true;
            GlobalCookies.CookieCount -= 200;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }
    }

    public void displayViolets() {
        if (shopItem != null && GlobalCookies.CookieCount >= 10) {
            shopItem.SetActive(true);
            Violets = true;
            GlobalCookies.CookieCount -= 10;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }
    }

    public void displayPictureFrame() {
        if (shopItem != null && GlobalCookies.CookieCount >= 100) {
            shopItem.SetActive(true);
            Frame = true;
            GlobalCookies.CookieCount -= 100;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }
    }

    public void displayVandersGauntlets() {
        if (shopItem != null && GlobalCookies.CookieCount >= 250) {
            shopItem.SetActive(true);
            Gauntlets = true;
            GlobalCookies.CookieCount -= 250;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }
    }

    public void displayCupcakes() {
        if (shopItem != null && GlobalCookies.CookieCount >= 50) {
            shopItem.SetActive(true);
            Cupcakes = true;
            GlobalCookies.CookieCount -= 50;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }
    }

    public void displayBunny() {
        if (shopItem != null && GlobalCookies.CookieCount >= 175) {
            shopItem.SetActive(true);
            Bunny = true;
            GlobalCookies.CookieCount -= 175;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }


    public void displayRealCupcake() {
        if (shopItem != null && GlobalCookies.CookieCount >= 2000) {
            shopItem.SetActive(true);
            Cait = true;
            GlobalCookies.CookieCount -= 2000;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void displayJinx() {
        if (shopItem != null && GlobalCookies.CookieCount >= 1000) {
            shopItem.SetActive(true);
            Jinx = true;
            GlobalCookies.CookieCount -= 1000;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }    
        }    
    }

    public void displayMonkey() {
        if (shopItem != null && GlobalCookies.CookieCount >= 500) {
            shopItem.SetActive(true);
            Monkey = true;
            GlobalCookies.CookieCount -= 500;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }    
        }    
    }

    public void displayChair() {
        if (shopItem != null && GlobalCookies.CookieCount >= 3000) {
            shopItem.SetActive(true);
            Chair = true;
            GlobalCookies.CookieCount -= 3000;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }    
        }    
    }

    public void displayvi6() {
        if (shopItem != null && GlobalCookies.CookieCount >= 66) {
            vi6 = true;
            GlobalCookies.CookieCount -= 66;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void displayTwoForOne() {
        if (shopItem != null && GlobalCookies.CookieCount >= 100) {
            twoForOne = true;
            sixForOne = false;
            GlobalCookies.CookieCount -= 100;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void displaytenHit() {
        if (shopItem != null && GlobalCookies.CookieCount >= 150) {
            tenHit = true;
            GlobalCookies.CookieCount -= 150;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void displaySixForOne() {
        if (shopItem != null && GlobalCookies.CookieCount >= 200) {
            sixForOne = true;
            twoForOne = false;
            GlobalCookies.CookieCount -= 200;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }
    public void displayfiveonesix() {
        if (shopItem != null && GlobalCookies.CookieCount >= 516) {
            fiveOneSix= true;
            GlobalCookies.CookieCount -= 516;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void displayDentingBlows() {
        if (shopItem != null && GlobalCookies.CookieCount >= 1000) {
            DentingBlows= true;
            GlobalCookies.CookieCount -= 1000;
            if (GlobalCookies.CookieCount < 0) {
                GlobalCookies.CookieCount = 0;
            }
        }    
    }

    public void noShow() {
        if (Bunny != true) {
            shopItem.SetActive(false);
        }
    }
    
    public void showBunny2() {
        if (Bunny == true) {
            shopItem.SetActive(true);
        }
    }

}
