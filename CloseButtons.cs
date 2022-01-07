using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtons : MonoBehaviour
{
    public GameObject Panel;
    
    public void showPanel() {
        if (Panel != null) {
            Panel.SetActive(true);
        }
    }


}
