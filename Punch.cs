using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {
    public GameObject textBox;
    public static int checkThird = 0;
    public static int checkTen = 0;
    
    public void ClickTheButton() {
        
        if (DisplayItems.tenHit == true) {
            checkTen += 1;
        }
        
        if (DisplayItems.DentingBlows == true) {
            checkThird += 1;
        }

        GlobalCookies.CookieCount += 1;
        
        if (DisplayItems.twoForOne == true) { 
            GlobalCookies.CookieCount += 1;
        }

        if (DisplayItems.fiveOneSix == true) {
            if (GlobalCookies.five_one_six == 1) {
                GlobalCookies.CookieCount += 516;
            }
        }

        if (DisplayItems.sixForOne == true) {
            GlobalCookies.CookieCount += 5;
        }

        if (DisplayItems.vi6 == true) {
            if (GlobalCookies.CookieCount % 6 == 0) {
                GlobalCookies.CookieCount += 1;
            }
        }

        if (DisplayItems.tenHit == true && checkTen == 10) {
            GlobalCookies.CookieCount += 10;
            checkTen = 0;
        }

        if (DisplayItems.DentingBlows == true && checkThird == 3) {
            int one_third = GlobalCookies.CookieCount / 3;
            GlobalCookies.CookieCount += one_third;
            checkThird = 0;
        }
    }
}