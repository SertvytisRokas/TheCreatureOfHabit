using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerlvl2 : MonoBehaviour
{

    public Text timer;
    public static float time;
    
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //time = Mathf.Round(time * 10.0f) * 0.1f;
        timer.text = time.ToString("F0") + " seconds" ;
    }
}
