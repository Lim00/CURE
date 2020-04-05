using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterHealth : MonoBehaviour
{
    public int startHealth = 200;
    public int currentHealth;

    public void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("MainCharacter damage taken");

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("MainCharacter die");
        Destroy(gameObject);
    }
}
