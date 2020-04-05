using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float timeBetweenAttack;
    public float startTimeBetweenAttack;
    public int meleeMaxNumAttack = 3;

    public Transform attackPosition;
    public LayerMask whatIsFriendly;
    public float attackRange;
    public int damage;

    void Update()
    {
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsFriendly);

        if(enemiesToDamage != null)
        {
            AttackMeelee(meleeMaxNumAttack, damage, damage, enemiesToDamage);
        }
    }

    void AttackMeelee(int meleeMax, int damageClass, int damageBot, Collider2D[] enemies)
    {
        if (timeBetweenAttack <= 0)
        {
            for (int i = 0; i < enemies.Length && i < meleeMax; i++)
            {
                if (enemies[i].GetComponent<BotHealth>()) // If it is a Bot
                {
                    enemies[i].GetComponent<BotHealth>().TakeDamage(damageBot);
                }
                else if (enemies[i].GetComponent<ClassHealth>()) // If it is a Class
                {
                    enemies[i].GetComponent<ClassHealth>().TakeDamage(damageClass);
                }
                else if(enemies[i].GetComponent<MainCharacterHealth>()) // If it is a Main character
                {
                    enemies[i].GetComponent<MainCharacterHealth>().TakeDamage(damageClass);
                }
            }
            timeBetweenAttack = startTimeBetweenAttack;
        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
    }

    void AttackBullets(int meleeMax, int damage)
    {

    }

    void AttackProjectile(int meleeMax, int damage)
    {

    }

    void AttackArea(int meleeMax, int damage)
    {

    }
}
