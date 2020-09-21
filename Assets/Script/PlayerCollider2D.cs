using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    Collider2D col;

    float distToGround;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        distToGround = col.bounds.extents.y;

    }

   

    private void FixedUpdate()
    {


        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(4, rb2d.velocity.y);
            animator.Play("runn");
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-4, rb2d.velocity.y);
            animator.Play("runn");
            spriteRenderer.flipX = true;
        }

        else {
            animator.Play("idle");
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        if (Input.GetKey("space") || Input.GetKey("up")){
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);

        }
    }

}
