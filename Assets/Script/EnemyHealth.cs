using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startHealth = 100;
    public int currentHealth;

    public void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy damage taken");

        if(currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("Enemy die");
        Destroy(gameObject);
    }
}
