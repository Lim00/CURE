using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject MainCharacterToFollow;
    public float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacterToFollow = GameObject.Find("MainCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MainCharacterToFollow.transform.position, moveSpeed * 0.1f);
    }
}
