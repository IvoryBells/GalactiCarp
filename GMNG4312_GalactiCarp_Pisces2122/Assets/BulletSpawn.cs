using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    //bullet
  //  public GameObject player;
    public GameObject bulletPrefab;
   // public GameObject bulletSpawner;

    //bullet force
    public float shootForce;

   //Shoot stats
   // public float tBShoot, spread, tBShots;
    //public int m, b;
    public bool allowHold;
    int l, s;

    bool shooting, ready;

    public Camera sCam;
    public Transform attackPoint;

    //public bool allowInvoke = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MyInput();

















        /*
        if (Input.GetButtonDown("Fire2"))
        {
            //Rigidbody bulletInstance;
           GameObject currentBullet =  Instantiate(bulletPrefab, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
            currentBullet.GetComponent<Rigidbody>().AddForce(player.transform.position * 500. ForceMode.Impulse);
        }
        */
    }

    
    private void MyInput()
    {
        
        shooting = Input.GetButtonDown("Fire2");
               
        //Shooting
        if(shooting)
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        Ray ray = sCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        RaycastHit hit;


        Vector3 targetPoint;
        if(Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        else
        {
            targetPoint = ray.GetPoint(75);
        }


        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;


        //Instantiate bullet
        GameObject currentBullet = Instantiate(bulletPrefab, attackPoint.position, Quaternion.identity);

        currentBullet.transform.forward = directionWithoutSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithoutSpread.normalized * shootForce, ForceMode.Impulse);
    }
    
}
