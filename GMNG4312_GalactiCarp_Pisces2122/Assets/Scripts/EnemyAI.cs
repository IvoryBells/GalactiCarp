using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public NavMeshAgent Bug;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float health;
    //attacking Gate
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //attacking player
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //states
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInattackRange;

    private void Awake()
    {
        player = GameObject.Find("-----Upgrade 4-----").transform;
        Bug = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInattackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInattackRange) Patroling();
        if (playerInSightRange && !playerInattackRange) ChasePlayer();
        if (playerInSightRange && playerInattackRange) AttackPlayer();
    }

    private void Patroling()
    {
        if (!walkPointSet) SearchGate();
        if(walkPointSet)
        {
            Bug.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //walkPoint reached
        if(distanceToWalkPoint.magnitude < 1f)
        {
            AttackGate();
        }
    }
    private void SearchGate()
    {
        //Find gate
    }
    private void AttackGate()
    {
        //gate takes damage
    }

    private void ChasePlayer()
    {
        Bug.SetDestination(player.position);
    }
    private void AttackPlayer()
    {
        Bug.SetDestination(transform.position);
        transform.LookAt(player);

        if(!alreadyAttacked)
        {
            HealthSystem.Instance.TakeDamage(10f);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void takeDamage(float damage)
    {
        health -= damage;

        if(health<=0)
        {
            Invoke(nameof(destroyEnemy), 0.5f);
        }
    }

    private void destroyEnemy()
    {
        Destroy(gameObject);
    }
}
