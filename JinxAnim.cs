using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinxAnim : MonoBehaviour
{
    public GameObject JinxSprite;
    public Animator anim;

    public void ClickTheButton() {
        if (DisplayItems.Cait == true) {
            anim.Play("jinx anim");
        }
    }
}
