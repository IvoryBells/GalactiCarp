using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelCollectible : MonoBehaviour
{
    public GameObject playerSpawner;    
    //public AudioSource collectSound;
    void Awake()
    {
        playerSpawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            //collectSound.Play();
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level_2_Cutscene");
            Destroy(gameObject);
        }
    }
}
