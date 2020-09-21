using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }
    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    void DestroyBullet() {
        Destroy(gameObject);
    }
}
