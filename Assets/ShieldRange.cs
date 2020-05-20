using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRange : MonoBehaviour
{
    public float shieldRange = 4f;
    public LayerMask whatIsFriendly;
    public Collider2D collider;

    public float HEAL_TIMER = 2f;
    private float heal_thick;

    private void Start()
    {
        collider = gameObject.GetComponent<Collider2D>();
        heal_thick = 0.0f;
        // shieldRange = ~;

    }

    void Update()
    {
        heal_thick += 0.1f * Time.deltaTime;

        if(heal_thick >= HEAL_TIMER)
        {
            Healing(); // Periodical automatic healing

            heal_thick = 0.0f;
        }
    }

    /// <summary>
    /// Heal nearby Friendly GameObject
    /// </summary>
    public void Healing()
    {
        Collider2D[] friendsToHeal = Physics2D.OverlapCircleAll(transform.position, shieldRange, whatIsFriendly);

        for (int i = 0; i < friendsToHeal.Length; i++)
        {
            /* 
            if (friendsToHeal[i].GetComponent<ClassHealth>())
            {
                Debug.Log(" === Class healed === ");
                friendsToHeal[i].GetComponent<ClassHealth>().currentHealth += 1;
            }
            else if (friendsToHeal[i].GetComponent<BotHealth>())
            {
                Debug.Log(" === Bot healed === ");
                friendsToHeal[i].GetComponent<BotHealth>().currentHealth += 1;
            }
            */
        }
    }
}
