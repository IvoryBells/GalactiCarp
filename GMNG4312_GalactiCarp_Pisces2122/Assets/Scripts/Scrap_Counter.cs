using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_Counter : MonoBehaviour
{

    static public int scrapCount = 0;

    void OnGUI()
    {
        GUI.skin.box.fontSize = 35;
        GUI.Box(new Rect(10, 10, 400, 100), "Scrap collected: " + scrapCount);
    }
}
