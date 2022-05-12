using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmEnemy : MonoBehaviour
{
    public float health = 50f;
    public float bossHealth = 100f;
    public int deathCount = 0;

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
            deathCount++;
            if(deathCount == 29)
            {
                //spawn queen 
            }
        }
    }
}
