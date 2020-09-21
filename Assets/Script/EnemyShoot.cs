using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform target;


    private float distance;
    SpriteRenderer spriteRenderer;

    float fireRate;
    float nextFire;

    
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = (target.transform.position.x - transform.position.x);
        checkWhenFire();
        checkFlip();
    }

    void checkWhenFire() {
        if (Time.time > nextFire && distance > -15f && distance < -5f) {

            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
            

        }
        else if (Time.time > nextFire && distance > 5f && distance < 15f) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
            
        }
    }

    void checkFlip() {
        if (distance <= 0)
        {
            spriteRenderer.flipX = false;
        }
        else {
            spriteRenderer.flipX = true;
        }
    }

    

    
}
