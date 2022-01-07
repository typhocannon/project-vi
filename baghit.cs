using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baghit : MonoBehaviour
{
    public GameObject punchingBag;
    public Animator anim;
    
    public void ClickTheButton() {
        anim.Play("actual_hit");
    }
}
