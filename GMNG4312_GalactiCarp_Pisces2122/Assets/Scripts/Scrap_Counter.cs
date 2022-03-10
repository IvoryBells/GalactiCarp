using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_Counter : MonoBehaviour
{

    static public int scrapCount = 0;
    static public int scrap_goal;

    
   

    void OnGUI()
    {
        GUI.skin.box.fontSize = 35;

        /*if (scrapCount < 10)
        {
            scrap_goal = 10;
        }
        */
        for(int i = 0;i < 5; i++)
        {
            if (scrapCount<(i+1)*10)
            {
                scrap_goal = (i+1) * 10;
                break;
            }

            //if(scrapCount >= 20 && scrapCount < 40)
           // {


           // }
        }

        GUI.Box(new Rect(10, 10, 400, 100), "Scrap collected: " + scrapCount + "/" + scrap_goal);
    }
}
