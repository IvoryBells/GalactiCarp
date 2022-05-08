using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera tpsCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(tpsCam.transform.position, tpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            HarmEnemy  enemy = hit.transform.GetComponent<HarmEnemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }

        }
    }
}
