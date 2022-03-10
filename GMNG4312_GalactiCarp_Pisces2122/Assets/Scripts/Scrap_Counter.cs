using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_Counter : MonoBehaviour
{

    static public int scrapCount = 0;
    int scrap_goal;
    public AudioClip upgradeSound;

    void OnGUI()
    {
        GUI.skin.box.fontSize = 35;

        /*if (scrapCount < 10)
        {
            scrap_goal = 10;
        }
        */

        if(scrapCount == 10)
        {
            AudioSource.PlayClipAtPoint(upgradeSound, transform.position);
        }
        else if (scrapCount == 20)
        {
            AudioSource.PlayClipAtPoint(upgradeSound, transform.position);
        }
        else if (scrapCount == 30)
        {
            AudioSource.PlayClipAtPoint(upgradeSound, transform.position);
        }
        else if (scrapCount == 40)
        {
            AudioSource.PlayClipAtPoint(upgradeSound, transform.position);
        }
        else if (scrapCount == 50)
        {
            AudioSource.PlayClipAtPoint(upgradeSound, transform.position);
        }

        for (int i = 0;i < 5; i++)
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
