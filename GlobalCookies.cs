using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies: MonoBehaviour
{
    public static int CookieCount;
    public static int num;
    public static int five_one_six;
    public GameObject CookieDisplay;
    public int InternalCookie;

    void Update() {
        if (DisplayItems.fiveOneSix == true) {
            five_one_six = Random.Range(1, 21);
        }
        num = Random.Range(1, 11);
        InternalCookie = CookieCount;
        CookieDisplay.GetComponent<Text>().text = "Punches: " +  InternalCookie;
    }

}