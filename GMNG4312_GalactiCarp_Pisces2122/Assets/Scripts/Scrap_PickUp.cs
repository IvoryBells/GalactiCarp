using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_PickUp : MonoBehaviour
{

    int scrapVal = 1;
    public AudioClip scrapSound;
    void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Player")
        {
            //keep track of scrap collected and add to total 
            //Display total scrap collected

            Scrap_Counter.scrapCount += scrapVal;
            AudioSource.PlayClipAtPoint(scrapSound, transform.position);
            Destroy(gameObject);
        }
    }
}
