using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public float moveSpeed;

    public Transform attackPosition;
    public float attackRange; 

    public Vector2 startPosition; // Initial position = Start of the stage
    public Vector2 endPosition; // End position = End of the stage
    public LayerMask whatIsEnemy; // If find this layer's object, stop

    Collider2D[] enemiesToDamage; // Find objects witin the rrange

    void Start()
    {
        startPosition.x = -10;
        startPosition.y = 0;

        transform.position = startPosition;

        endPosition.x = 30;
        endPosition.y = 0;
    }

    void Update()
    {
        enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsEnemy);

        if (transform.position.x < endPosition.x) // If not reach the end of the stage
        {
            if (enemiesToDamage.Length == 0)
            {
                Vector2 newPos = transform.position;
                newPos.x += 0.3f;

                transform.position = Vector3.MoveTowards(transform.position, newPos, moveSpeed * Time.deltaTime);
            }
        }
        else // Reach the end of the stage
        {
            // Destroy this bot
            Destroy(gameObject);
        }
        
    }
}
