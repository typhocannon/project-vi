using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAnims : MonoBehaviour
{
    public GameObject viSprite;
    public Animator anim;

    public void ClickTheButton() {
        if (GlobalCookies.num <= 5) {
            anim.Play("vi_left");
        }
        else {
            anim.Play("vi_right");
        }
    }
}
