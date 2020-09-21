using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5Dialog : MonoBehaviour
{
    public GameObject dialog1;
    public GameObject continueButton;
    public AudioSource audio;
    int buttonCounter;
    void Start()
    {
        dialog1.SetActive(false);
        continueButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        inputCounter();
        dialogUpdate();
    }

    void inputCounter()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            buttonCounter++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            buttonCounter--;
        }
    }

    void dialogUpdate()
    {

        // Constant
        if (buttonCounter < -0)
        {
            buttonCounter = -0;
        }
        if (buttonCounter == 1) {
            audio.Play();
        }

        if (buttonCounter == 2) {
            dialog1.SetActive(true);
            

        }
        if (buttonCounter > 2) {
            dialog1.SetActive(false);
            continueButton.SetActive(true);
            buttonCounter = 3;
        }


    }
}
