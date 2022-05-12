using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBug : MonoBehaviour
{
    public AudioSource crunch;
    public GameObject player;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            crunch.Play();

            player.GetComponent<winCondition>().bugsDead += 1;
        }
    }
}
