﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAttack : MonoBehaviour
{
    private float timeBetweenAttack;
    public float startTimeBetweenAttack;
    public int meleeMaxNumAttack = 3;
    public int bulletMaxNumAttack = 2;

    public Transform attackPosition;
    public LayerMask whatIsEnemy;
    public float attackRange;
    public int damage;

    
    void Update()
    {
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsEnemy);

        if (enemiesToDamage != null)
        {
            AttackMeelee(meleeMaxNumAttack, damage, enemiesToDamage);
        }
    }

    void AttackMeelee(int meleeMax, int damage, Collider2D[] enemies)
    {
        if (timeBetweenAttack <= 0)
        {
            for (int i = 0; i < enemies.Length && i < meleeMax; i++)
            {
                Debug.Log(enemies[i].gameObject);
                enemies[i].GetComponent<EnemyHealth>().TakeDamage(damage);
            }
            timeBetweenAttack = startTimeBetweenAttack;
        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
    }

    void AttackBullets(int meleeMax, int damage, Collider2D[] enemies)
    {
       
    }

    void AttackProjectile(int meleeMax, int damage)
    {

    }
}