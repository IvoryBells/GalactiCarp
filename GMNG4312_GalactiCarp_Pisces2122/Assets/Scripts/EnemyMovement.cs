using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform Destination;
    GameObject player;

    NavMeshAgent navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(navMeshAgent == null)
        {
            Debug.LogError("the nav mesh agent component is not attated to " + gameObject.name);
        }
        else
        {
            setDestination();
        }
    }


    private void Update()
    {
        setDestination();
    }

    private void setDestination()
    {

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                Destination = player.transform;
                Vector3 targetVector = player.transform.position;
                navMeshAgent.SetDestination(targetVector);
            }
        }
    }
}
