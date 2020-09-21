﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{

    Image healthBar;
    float maxHealth = 100f;
    public static float health;



    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        //checkIfDead();
    }
    /*
    void checkIfDead() {
        if (health <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }*/
}
