using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{

    public Transform Destination;
    GameObject player;
    public NavMeshAgent navMeshAgent;
    public LayerMask whatIsGround, whatIsPlayer;

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public float attackRange;
    public bool playerInAttackRange;

    // Start is called before the first frame update

    private void Awake()
    {
        setDestination();
        navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        if(navMeshAgent == null)
        {
            Debug.LogError("the nav mesh agent component is not attated to " + gameObject.name);
        }
    }


    private void Update()
    {
        setDestination();

        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInAttackRange)
        {
            ChasePlayer();
        }

        if (playerInAttackRange)
        {
            AttackPlayer();
        }

    }

    //patrolling
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

    //Attacking
    private void AttackPlayer()
    {
        navMeshAgent.SetDestination(Destination.position);

        transform.LookAt(Destination.position);

        if(!alreadyAttacked)
        {
            HealthSystem.PlayerHealth.TakeDamage(15);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void ChasePlayer()
    {
        navMeshAgent.SetDestination(Destination.position);

    }

}
