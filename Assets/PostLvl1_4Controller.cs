using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLvl1_4Controller : MonoBehaviour
{
    public GameObject dialog;
    int buttonCounter = 0;
    public GameObject continueButton;


    void Start()
    {
        dialog.SetActive(false);
        continueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        inputCounter();
        controlCutscene();
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

    void controlCutscene()
    {
        if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }

        if (buttonCounter == 1) {
            dialog.SetActive(true);
        }

        if (buttonCounter > 1) {
            dialog.SetActive(false);
            continueButton.SetActive(true);
            buttonCounter = 2;
        }
    }




    }
