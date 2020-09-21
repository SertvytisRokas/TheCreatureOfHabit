using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platformslayerMask;
    private Player_Base playerBase;
    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    Animator animator;
    private bool facingRight;

    Material material;
    Renderer renderer;
    float damageStartTime;

    public GameObject playerBulletRight, playerBulletLeft;

    bool canJump;

    //public GameObject restartButton, gameOverText;

    private void Start()
    {
        facingRight = true;
        animator = gameObject.GetComponent<Animator>();
        playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
        renderer = GetComponent<Renderer>();
        material = renderer.material;

        canJump = true;

        //restartButton.SetActive(false);
        //gameOverText.SetActive(false);
    }

    private void Update()
    {

        StartCoroutine(Jump());
        
        float horizontal = Input.GetAxis("Horizontal");
       

        HandleMovement();

        Flip(horizontal);
        //checkIfDead();

        changeColor();

      //  if (Input.GetKeyDown(KeyCode.Escape)) {
   //         Application.Quit();
     //   }

        

    }

    IEnumerator Jump() {
        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            float jumpVelocity = 30f;
            rigidbody2D.velocity = Vector2.up * jumpVelocity;
            canJump = false;
            
            yield return new WaitForSeconds(0.55f);
            canJump = true;
            
        }
    }

    private bool isGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size,
             0f, Vector2.down * .1f, platformslayerMask);
        //Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

    private void HandleMovement() {
        if (damageStartTime != 0)
        {
            float gbColor = (Time.timeSinceLevelLoad - damageStartTime) / 0.5f;

            material.color = new Color(1, gbColor, gbColor, 1);

            if (gbColor > 1)
            {
                damageStartTime = 0;
                material.color = Color.white;
            }
        }
        float moveSpeed = 12f;
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y);
            animator.Play("runn");
        }
        else {
            if (Input.GetKey(KeyCode.D))
            {
                rigidbody2D.velocity = new Vector2(+moveSpeed, rigidbody2D.velocity.y);
                animator.Play("runn");
            }
            else {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
                animator.Play("idle");
            }
        }
    }

    private void Flip(float horizontal) {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;

            scale.x *= -1;

            transform.localScale = scale;
        }
    }
    /*
    void checkIfDead() {
        if (HealthBar.health <= 0) {
            // gameOverText.SetActive(true);
            // restartButton.SetActive(true);
            // gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
    */

    void changeColor() {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet") {
            
            damageStartTime = Time.timeSinceLevelLoad;
        }
    }
}
