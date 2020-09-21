using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{

    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = Timerlvl2.time.ToString("F0") + " seconds!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
