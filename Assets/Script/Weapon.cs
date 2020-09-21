using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    /*
    Vector3 shootDirection;

    private void Update()
    {
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
    }
    */


    
    public float offSet;
    public Rigidbody2D projectile;
    public Transform shotPoint;

    private float timeBetweenShots;
    public float startTime;
    public float speed;

    

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offSet);



        if (timeBetweenShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(difference.x * speed, difference.y * speed);
                timeBetweenShots = startTime;

                
                
            }
        }
        else {
            timeBetweenShots -= Time.deltaTime;
        }
        

    }

    
    
}
