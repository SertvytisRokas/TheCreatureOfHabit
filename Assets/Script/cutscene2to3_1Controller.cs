using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene2to3_1Controller : MonoBehaviour
{
    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;

    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    public GameObject continueButton;
    int buttonCounter = 0;


    void Start()
    {
        continueButton.SetActive(false);

        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);

        background1.SetActive(true);
        background2.SetActive(false);
        background3.SetActive(false);
    }

    
    void Update()
    {
        inputCounter();
        controlCutscene();
    }

    void inputCounter() {

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            buttonCounter++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            buttonCounter--;
        }

    }

    void controlCutscene() {

        if (buttonCounter < 0) {
            buttonCounter = 0;
        }

        if (buttonCounter == 1) {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);

            background1.SetActive(true);
            background2.SetActive(false);
            background3.SetActive(false);
        }

        if (buttonCounter == 2) {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
            dialog3.SetActive(false);
            dialog4.SetActive(false);

            background1.SetActive(true);
            background2.SetActive(false);
            background3.SetActive(false);
        }

        if (buttonCounter == 3) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);

            background1.SetActive(false);
            background2.SetActive(true);
            background3.SetActive(false);
        }

        if (buttonCounter == 4) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(true);
            dialog4.SetActive(false);

            background1.SetActive(false);
            background2.SetActive(true);
            background3.SetActive(false);
        }

        if (buttonCounter == 5) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);

            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(true);
        }

        if (buttonCounter == 6) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);

            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(true);
        }

        if (buttonCounter > 6) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);

            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(true);

            continueButton.SetActive(true);
            buttonCounter = 7;
        }

    }


}
