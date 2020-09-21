using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTile : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
