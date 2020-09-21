using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLvl3_2Controller : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public GameObject scene5;

    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;
    public GameObject dialog5;
    public GameObject dialog6;
    public GameObject dialog7;
    public GameObject dialog8;
    public GameObject dialog9;
    public GameObject dialog10;
    public GameObject dialog11;
    public GameObject dialogF;

    public GameObject creature1;
    public GameObject creature2;
    public GameObject creature3;

    public GameObject continueButton;
    int buttonCounter = 0;

    void Start()
    {
        continueButton.SetActive(false);

        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        dialog5.SetActive(false);
        dialog6.SetActive(false);
        dialog7.SetActive(false);
        dialog8.SetActive(false);
        dialog9.SetActive(false);
        dialog10.SetActive(false);
        dialog11.SetActive(false);
        dialogF.SetActive(false);

        scene1.SetActive(true);
        scene2.SetActive(false);
        scene3.SetActive(false);
        scene4.SetActive(false);
        scene5.SetActive(false);

        creature1.SetActive(true);
        creature2.SetActive(false);
        creature3.SetActive(false);
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
        if (buttonCounter < 0) {
            buttonCounter = 0;
        }

        if (buttonCounter == 1) {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(true);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 2)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(true);
            creature3.SetActive(false);
        }
        if (buttonCounter == 3)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
            dialog3.SetActive(true);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(true);
            creature3.SetActive(false);
        }
        if (buttonCounter == 4)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(true);
        }

        if (buttonCounter == 5)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(true);
        }

        if (buttonCounter == 6)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 7)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(true);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 8)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(true);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
            dialogF.SetActive(false);
        }

        if (buttonCounter == 9)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 10)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(true);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 11)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(true);
            dialog7.SetActive(true);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 12)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(true);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 12)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(true);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 13)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            scene4.SetActive(false);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }
        if (buttonCounter == 14)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 15)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(true);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 16)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(true);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 17)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
            scene5.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }
        if (buttonCounter == 18)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 19)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(true);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter == 20)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(true);
            dialog11.SetActive(true);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
        }

        if (buttonCounter > 20) {
            buttonCounter = 21;

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
            dialog11.SetActive(false);
            dialogF.SetActive(false);

            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);

            continueButton.SetActive(true);
        }
    }
}
