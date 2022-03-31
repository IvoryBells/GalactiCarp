using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] playerModel;
    public GameObject thePlayer;
    public Vector3 playerLoc;
    public bool up1, up2, up3, up4 = false;


    void Start()
    {
        thePlayer = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        UpgradeSuit();
    }

    public void UpgradeSuit()
    {
        if (this.GetComponent<Scrap_Counter>().scrapCount == 10 && up1 == false)
        {
            playerLoc = thePlayer.transform.localPosition;
            Destroy(thePlayer);
            Instantiate(playerModel[1], playerLoc, Quaternion.identity);
            up1 = true;
        }

        thePlayer = GameObject.FindGameObjectWithTag("Player");
        /*for (int i = 0; i < 5; i++)
        {
            if (playerModel[i].GetComponent<Scrap_Counter>().scrapCount == (i + 1) * 10)
            {
                Destroy(playerModel[i]);
                Instantiate(playerModel[i + 1]);
            }
            if (Scrap_Counter.scrapCount == (i + 1) * 10)
            {

                Destroy(playerModel[i]); 
                Instantiate(playerModel[i + 1]);
            }
    }*/

    }

    
}
