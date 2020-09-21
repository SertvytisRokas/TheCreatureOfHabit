using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField]
    Player player;

    public static float totalHealth;

    private void Start()
    {
        totalHealth = 1;
    }

    private void Update()
    {
        if (totalHealth <= 0) {
            Destroy(player);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("bullet")) {
            totalHealth -= 0.1f;
            Debug.Log("Hit");
        }
    }


}
