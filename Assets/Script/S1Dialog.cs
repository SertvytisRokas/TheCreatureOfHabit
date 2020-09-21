using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1Dialog : MonoBehaviour
{
    public GameObject continueButton;
    public AudioSource knockAudio;

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

    }

    
    void Update()
    {
        inputCounter();
        dialogUpdate();
    }

    void inputCounter() {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            buttonCounter++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            buttonCounter--;
        }
    }

    void dialogUpdate() {
        // Constant
        if (buttonCounter < 0) {
            buttonCounter = 0;
        }

        //Move 1
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

            knockAudio.Play();
        }
        // Move 2
        if (buttonCounter == 2) {
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
        }
        // Move 3
        if (buttonCounter == 3) {
            dialog2.SetActive(false);
            dialog3.SetActive(true);

            dialog1.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 4
        if (buttonCounter == 4)
        {
            dialog3.SetActive(false);
            dialog4.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 5
        if (buttonCounter == 5)
        {
            dialog4.SetActive(false);
            dialog5.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 6
        if (buttonCounter == 6)
        {
            dialog5.SetActive(false);
            dialog6.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            
            dialog7.SetActive(false);
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 7
        if (buttonCounter == 7)
        {
            dialog7.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            
            dialog8.SetActive(false);
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 8
        if (buttonCounter == 8)
        {
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            
            dialog9.SetActive(false);
            dialog10.SetActive(false);
        }
        // Move 9
        if (buttonCounter == 9)
        {
            dialog8.SetActive(false);
            dialog9.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            
            dialog10.SetActive(false);
        }
        // Move 10
        if (buttonCounter > 9)
        {
            dialog9.SetActive(false);
            dialog10.SetActive(true);
            continueButton.SetActive(true);

            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            dialog5.SetActive(false);
            dialog6.SetActive(false);
            dialog7.SetActive(false);
            dialog8.SetActive(false);

            buttonCounter = 10;
            
        }
    }
}
