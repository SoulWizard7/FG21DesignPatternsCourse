using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIupdate : MonoBehaviour
{
    
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.TextArea(new Rect(0, 0, 200, 200), (Player.instance.health.ToString() + "/" + Player.instance.maxHealth));
        //GUI.Label(new Rect(0,0,200,200), Player.instance.health.ToString());
    }
}
