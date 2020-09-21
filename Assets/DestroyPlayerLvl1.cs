using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayerLvl1 : MonoBehaviour
{
     
    

    
    void Update()
    {
        if (HealthBar.health <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            SceneManager.LoadScene("GameOver");
        }
    }

}
