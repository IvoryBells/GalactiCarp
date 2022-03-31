using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap_PickUp : MonoBehaviour
{
    public GameObject playerSpawner;
    int scrapVal = 1;
    public AudioSource collectSound;
    void Awake()
    {
        playerSpawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Player")
        {
            //collectSound.Play();
            //keep track of scrap collected and add to total 
            //Display total scrap collected

            //Col.gameObject.GetComponent<Scrap_Counter>().scrapCount += scrapVal;
            playerSpawner.GetComponent<Scrap_Counter>().scrapCount += scrapVal;

            Destroy(gameObject);
        }
    }
}
