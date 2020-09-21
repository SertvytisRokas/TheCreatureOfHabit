using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLvl3_1Controller : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;

    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;
    public GameObject dialog5;
    public GameObject dialog6;

    public GameObject continueButton;
    int buttonCounter = 0;

    private void Start()
    {
        continueButton.SetActive(false);

        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        dialog5.SetActive(false);
        dialog6.SetActive(false);

        scene1.SetActive(true);
        scene2.SetActive(false);
        scene3.SetActive(false);
        scene4.SetActive(false);

    }

    private void Update()
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
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 2) {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 3) {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 4)
        {
            dialog1.SetActive(true);
            dialog2.SetActive(true);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 5)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(true);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 6)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }

        if (buttonCounter == 7 || buttonCounter == 8)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
        }

        if (buttonCounter == 9)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
        }

        if (buttonCounter == 10)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
        }

        if (buttonCounter == 11)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            dialog5.SetActive(true);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
        }

        if (buttonCounter == 12)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(true);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
        }

        if (buttonCounter > 12)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);

            continueButton.SetActive(true);
            buttonCounter = 13;
        }
    }

}
