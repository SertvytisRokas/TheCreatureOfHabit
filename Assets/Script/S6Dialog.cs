using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6Dialog : MonoBehaviour
{

    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject continueButton;

    int buttonCounter;


    void Start()
    {
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        continueButton.SetActive(false);
    }

    
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
        if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }


        if (buttonCounter == 1)
        {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
        }

        if (buttonCounter == 2) {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
        }

        if (buttonCounter >2) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            continueButton.SetActive(true);
            buttonCounter = 3;
        }


        }




    }
