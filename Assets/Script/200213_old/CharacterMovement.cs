using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    // For UI button event trigger
    private bool pressedLeft;
    private bool pressedRight;

    void FixedUpdate()
    {
        if (pressedLeft)
            GoLeft();
        if (pressedRight)
            GoRight();
    }

    public void GoRight()
    {
        Vector2 newPos = transform.position;
        newPos.x += 0.3f;

        transform.position = Vector3.MoveTowards(transform.position, newPos, moveSpeed * Time.deltaTime);
    }

    public void GoLeft()
    {
        Vector2 newPos = transform.position;
        newPos.x -= 0.3f;

        transform.position = Vector3.MoveTowards(transform.position, newPos, moveSpeed * Time.deltaTime);
    }

    public void LeftrDown()
    {
        pressedLeft = true;
    }

    public void LeftUp()
    {
        pressedLeft = false;
    }


    public void RightDown()
    {
        pressedRight = true;
    }

    public void RightUp()
    {
        pressedRight = false;
    }
}
