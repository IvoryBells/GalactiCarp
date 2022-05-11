using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject hold;
    
    //public Transform camThird;
    

    public float distance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = hold.transform.TransformPoint(new Vector3(0, 10, 0));
        Instantiate(myPrefab, pos, Quaternion.identity);
        
    }

   
}
