using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassCharacterMovement : MonoBehaviour
{
    public GameObject MainCharacterToFollow;
    public Vector2 anchorPosition;
    public float offset_x = -6.0f;
    public float offset_y = 0.0f;

    private bool isDraging;

    void Start()
    {
        MainCharacterToFollow = GameObject.Find("MainCharacter"); // Find main character

        anchorPosition = MainCharacterToFollow.transform.position; // Fix Class character's anchor
        anchorPosition.x += offset_x; // Give'em some space
        anchorPosition.y += offset_y;

        transform.position = anchorPosition;
    }

    void FixedUpdate()
    {
        if (isDraging)
        {
            ChangePosition();
        }
        else
        {
            anchorPosition = MainCharacterToFollow.transform.position;
            anchorPosition.x += offset_x;
            anchorPosition.y += offset_y;

            transform.position = anchorPosition;
        }
    }

    public void ChangePosition()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);

        offset_x = transform.position.x - MainCharacterToFollow.transform.position.x;
        offset_y = transform.position.y - MainCharacterToFollow.transform.position.y;
    }

    public void OnMouseDown()
    {
        isDraging = true;
    }

    public void OnMouseUp()
    {
        isDraging = false;
    }
}
