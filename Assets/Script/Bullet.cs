using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 30f;
    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    Animator animator;

    float damageStartTime;




    Material material;
    Renderer renderer;




    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        target = GameObject.FindObjectOfType<Player>();
        renderer = target.GetComponent<Renderer>();
        material = renderer.material;



        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 0.6f);

        

    }

    private void Update()
    {
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
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            HealthBar.health -= 10f;
            damageStartTime = Time.timeSinceLevelLoad;
            Destroy(gameObject);

            if (HealthBar.health <= 0)
            {
                Debug.Log("Dead");
                SceneManager.LoadScene("GameOver");
            }
        }
        else if (collision.gameObject.tag == "Border") {
            Destroy(gameObject);
        }
    }

    
}
