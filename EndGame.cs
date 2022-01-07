using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject Vi;
    public Animator viAnim;

    public GameObject Bag;
    public Animator bagAnim;

    public GameObject Panel;
    public AudioSource PunchSound;

    public GameObject Buttons;

    void Update() {
        if (GlobalCookies.CookieCount > 121912) {
            DisplayEndPanel();
            GlobalCookies.CookieCount = 121912;
        }
    }

    // plays ending animation
    public void DisplayEndPanel()
    {
        Buttons.SetActive(false);
        PunchSound.Play();
        viAnim.Play("bag break");
        bagAnim.Play("bag break");
    }

}
