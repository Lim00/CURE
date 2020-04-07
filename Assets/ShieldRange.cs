using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRange : MonoBehaviour
{
    public float shieldRange = 4f;
    public LayerMask whatIsFriendly;
    public Collider2D collider;

    private void Start()
    {
        collider = gameObject.GetComponent<Collider2D>();
        // shieldRange = ~;

    }

    void Update()
    {
        Collider2D[] friendsToHeal = Physics2D.OverlapCircleAll(transform.position, shieldRange, whatIsFriendly);

        for(int i = 0; i < friendsToHeal.Length; i++)
        {
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
        }
    }
}
