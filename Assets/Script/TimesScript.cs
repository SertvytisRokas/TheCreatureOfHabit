using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimesScript : MonoBehaviour
{

    Text time;
    public float maxTime = 60f;
    public float timeLeft;

    void Start()
    {
        time = GetComponent<Text>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        checkTime();
        time.text = timeLeft.ToString("F0");
    }

    void checkTime() {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else {
            SceneManager.LoadScene("GameOver");
        }
    }
}
