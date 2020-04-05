using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassCharacterMovement : MonoBehaviour
{
    public GameObject MainCharacterToFollow;
    public Vector2 anchorPosition;
    public int offset = -6;

    void Start()
    {
        MainCharacterToFollow = GameObject.Find("MainCharacter"); // Find main character

        anchorPosition = MainCharacterToFollow.transform.position; // Fix Class character's anchor
        anchorPosition.x += offset; // Give'em some space

        transform.position = anchorPosition;
    }

    void FixedUpdate()
    {
        anchorPosition = MainCharacterToFollow.transform.position; 
        anchorPosition.x += offset; 

        transform.position = anchorPosition;
    }
}
