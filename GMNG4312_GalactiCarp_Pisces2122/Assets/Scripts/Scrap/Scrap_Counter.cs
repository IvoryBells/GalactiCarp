using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_Counter : MonoBehaviour
{
    public GameObject theKey;
    public int scrapCount = 0;
    public int scrap_goal;

    void Update()
    {
        if(scrapCount!=50)
        {
            theKey.SetActive(false);
        }
        else
        {
            theKey.SetActive(true);
        }
    }
   

    void OnGUI()
    {
        GUI.skin.box.fontSize = 35;

        
        for(int i = 0;i < 5; i++)
        {
            if (scrapCount<(i+1)*10)
            {
                scrap_goal = (i+1) * 10;
                break;
            }
        }

        GUI.Box(new Rect(10, 10, 400, 100), "Scrap collected: " + scrapCount + "/" + scrap_goal);
    }
}
