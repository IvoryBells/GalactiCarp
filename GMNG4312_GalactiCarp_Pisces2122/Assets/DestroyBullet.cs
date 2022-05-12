using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float lifetime = 3.0f;
    // Start is called before the first frame update
    void Update()
    {
        Destroy(this.gameObject, lifetime);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //Destroy(this.gameObject);
        }
    }
}
