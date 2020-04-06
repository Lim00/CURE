using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject MainCharacterToFollow;
    public float moveSpeed = 0.1f;

    public LayerMask whatIsFriendly; // If find this layer's object, stop
    Collider2D[] friendsToDamge; // Find objects witin the rrange
    public float recognitionRange = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacterToFollow = GameObject.Find("MainCharacter");
        
    }

    // Update is called once per frame
    void Update()
    {
        friendsToDamge = Physics2D.OverlapCircleAll(transform.position, recognitionRange, whatIsFriendly);

        if(friendsToDamge.Length == 0)
            transform.position = Vector3.MoveTowards(transform.position, MainCharacterToFollow.transform.position, moveSpeed * 0.1f);
        else
            transform.position = Vector3.MoveTowards(transform.position, MainCharacterToFollow.transform.position, moveSpeed * 0.3f * 0.1f);
    }
}
