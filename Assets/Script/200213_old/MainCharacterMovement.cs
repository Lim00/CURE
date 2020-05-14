using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    private Rigidbody2D rig2d;
    private Animator anim;

    public float moveForce = 50f;
    public float maxSpeed = 2f;

    private float h; // Input
    private bool facingRight = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        rig2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Movement change to UI functionalities
    void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    /// <summary>
    /// TODO: Fix continuous forcing problems
    /// </summary>
    private void FixedUpdate()
    {
        // anim.SetFloat("Speed", Mathf.Abs(h));

        /* // Old version
        if(h * rig2d.velocity.x < maxSpeed)
        {
            rig2d.AddForce(Vector2.right * h * moveForce);
        }
        if(Mathf.Abs(rig2d.velocity.x) > maxSpeed)
        {
            rig2d.velocity = new Vector2(Mathf.Sign(rig2d.velocity.x) * maxSpeed, rig2d.velocity.y);
        }

        if(h > 0 && !facingRight) { Flip(); }
        else if(h < 0 && facingRight) { Flip(); }
        */
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
}
