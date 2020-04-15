using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHealth : MonoBehaviour
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
        Debug.Log("Bot is damaged");

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("Bot is dead");
        Destroy(gameObject);
    }
}
