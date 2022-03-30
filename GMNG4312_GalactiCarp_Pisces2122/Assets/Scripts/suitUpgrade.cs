using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] playerModel;

    public void UpgradeSuit()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Scrap_Counter.scrapCount == (i + 1) * 10)
            {

                Destroy(playerModel[i]); 
                Instantiate(playerModel[i + 1]);
            }
        }
    }
}
