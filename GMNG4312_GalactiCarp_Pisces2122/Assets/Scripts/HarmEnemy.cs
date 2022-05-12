using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarmEnemy : MonoBehaviour
{

    public GameObject player;

    /*
    public GameObject Queen;
    public GameObject bug;
    */
    public float health = 50f;
    public float bossHealth = 300f;



    public AudioSource crunch;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            crunch.Play();

            if (this.tag == "Enemy")
            {
                EnemyTakeDamage(10);
            }
            if(this.tag == "Boss")
            {
                BossTakeDamage(10);
            }
        }
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

        void Die()
        {
            
            Destroy(gameObject);
            player.GetComponent<winCondition>().bugsDead++;
        }
    }

    public void EnemyTakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

        void Die()
        {

            Destroy(gameObject);
            player.GetComponent<winCondition>().bugsDead++;
        }
    }

    public void BossTakeDamage(float amount)
    {
        bossHealth -= amount;
        

        if (bossHealth <= 0f)
        {
            Die();
        }

        void Die()
        {
            
            Destroy(gameObject);
            player.GetComponent<winCondition>().bugsDead++;

        }
    }


}
