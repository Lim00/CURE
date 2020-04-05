using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassHealth : MonoBehaviour
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
        Debug.Log("Class damage taken");

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("Class die");
        Destroy(gameObject);
    }
}
