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

        if(enemiesToDamage.Length > 0)
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
                
                // Debug.Log(enemies[i].gameObject);
                if (enemies[i].GetComponentInParent<BotHealth>()) // If it is a Bot
                {
                    Debug.Log("Bot hit");
                    enemies[i].GetComponentInParent<BotHealth>().TakeDamage(damageBot);
                }
                else if (enemies[i].GetComponentInParent<ClassHealth>()) // If it is a Class
                {
                    Debug.Log("Class hit");
                    enemies[i].GetComponentInParent<ClassHealth>().TakeDamage(damageClass);
                }
                else if(enemies[i].GetComponentInParent<MainCharacterHealth>()) // If it is a Main character
                {
                    Debug.Log("Main hit");
                    enemies[i].GetComponentInParent<MainCharacterHealth>().TakeDamage(damageClass);
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
