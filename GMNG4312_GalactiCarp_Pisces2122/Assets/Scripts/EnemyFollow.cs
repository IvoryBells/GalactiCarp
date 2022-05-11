using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject myTarget;
    public NavMeshAgent myagent;
    public int range;


    // Start is called before the first frame update
    void Start()
    {
      //  myTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, myTarget.transform.position);
        if (dist < range)
        {
            myagent.destination = myTarget.transform.position;
        }
    }
}