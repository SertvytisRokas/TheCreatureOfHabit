using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene2to3Controller : MonoBehaviour
{

    
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;
    public GameObject dialog5;

    int buttonCounter = 0;

    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public GameObject continueButton;
    
    void Start()
    {
        
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        dialog5.SetActive(false);

        panel2.SetActive(true);
        panel3.SetActive(false);
        panel4.SetActive(false);

        continueButton.SetActive(false);


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
            panel2.SetActive(true);
            panel3.SetActive(false);
            panel4.SetActive(false);
            dialog2.SetActive(true);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
        }

        if (buttonCounter == 2) {
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(false);

            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
        }

        if (buttonCounter == 3)
        {
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(false);

            dialog2.SetActive(false);
            dialog3.SetActive(true);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
        }

        if (buttonCounter == 4)
        {
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);

            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
        }

        if (buttonCounter == 5)
        {
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);

            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            dialog5.SetActive(false);
        }

        if (buttonCounter == 6)
        {
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);

            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            dialog5.SetActive(true);
        }

        if (buttonCounter > 6)
        {
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);

            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);

            continueButton.SetActive(true);
            buttonCounter = 7;
        }

    }


}
