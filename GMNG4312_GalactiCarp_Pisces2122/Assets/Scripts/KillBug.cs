using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBug : MonoBehaviour
{

    public AudioSource crunch;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            crunch.Play();

            Destroy(this.gameObject);
        }
    }
}
