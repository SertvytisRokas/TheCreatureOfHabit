using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public GameObject button;
    float timer=0;
    public float buttonTime;
    void Start()
    {
        button.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= buttonTime) {
            button.SetActive(true);
        }
    }
}
