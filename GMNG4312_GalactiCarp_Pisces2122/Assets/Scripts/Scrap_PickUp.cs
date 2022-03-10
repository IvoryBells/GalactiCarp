using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_PickUp : MonoBehaviour
{

    int scrapVal = 1;

    void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Player")
        {
            //keep track of scrap collected and add to total 
            //Display total scrap collected

            Scrap_Counter.scrapCount += scrapVal;

            Destroy(gameObject);
        }
    }
}
