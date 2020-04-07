using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startHealth = 100;
    public int currentHealth;

    // Damage effect. For now, it just a text popup
    public GameObject hitTextPrefab;

    public void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy damage taken");

        if (hitTextPrefab) // Only when the game object is assigned
        {
            ShowHitText();
        }
        
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    private void ShowHitText()
    {
        var go = Instantiate(hitTextPrefab, transform.position, Quaternion.identity, transform); // Make damage UI when hit by friendly
        go.GetComponent<TextMesh>().text = currentHealth.ToString();
    }

    public void Death()
    {
        Debug.Log("Enemy die");
        Destroy(gameObject);
    }
}
