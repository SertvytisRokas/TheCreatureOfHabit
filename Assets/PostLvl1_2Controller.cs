using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLvl1_2Controller : MonoBehaviour
{
    public GameObject dialog1;
 
    public GameObject creature1;
    public GameObject creature2;

    public GameObject continueButton;

    int buttonCounter = 0;

    void Start()
    {
        dialog1.SetActive(false);


        creature1.SetActive(true);
        creature2.SetActive(false);

        continueButton.SetActive(false);

    }


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

    void controlCutscene() {
        if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }

        if (buttonCounter == 1) {
            creature1.SetActive(false);
            creature2.SetActive(true);
            dialog1.SetActive(true);
        }
        if (buttonCounter > 1) {
            creature1.SetActive(false);
            creature2.SetActive(true);
            dialog1.SetActive(false);

            continueButton.SetActive(true);
            buttonCounter = 2;
        }
    }
}
