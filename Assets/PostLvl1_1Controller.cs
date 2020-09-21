using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLvl1_1Controller : MonoBehaviour
{

    public GameObject dialog1;
    public GameObject dialog2;

    public GameObject creature1;
    public GameObject creature2;

    public GameObject continueButton;

    int buttonCounter = 0;

    void Start()
    {
        dialog1.SetActive(false);
        dialog2.SetActive(false);

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

    void controlCutscene()
    {

        if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }

        if (buttonCounter == 1) {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            creature1.SetActive(true);
            creature2.SetActive(false);
        }

        if (buttonCounter == 2) {
            dialog1.SetActive(false);
            dialog2.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(true);

        }

        if (buttonCounter > 2) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            creature1.SetActive(false);
            creature2.SetActive(true);

            continueButton.SetActive(true);
            buttonCounter = 3;
        }

    }


}
