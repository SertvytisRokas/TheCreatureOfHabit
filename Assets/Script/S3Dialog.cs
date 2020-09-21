using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3Dialog : MonoBehaviour
{
    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;

    public GameObject effect;
    public GameObject effect2;

    int buttonCounter = 0;

    public GameObject continueButton;

    public GameObject creature1;
    public GameObject creature2;
    public GameObject creature3;
    public GameObject creature4;

    public AudioSource audio1;

    void Start()
    {
        continueButton.SetActive(false);
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        effect.SetActive(false);
        effect2.SetActive(false);

        creature1.SetActive(true);
        creature2.SetActive(false);
        creature3.SetActive(false);
        creature4.SetActive(false);

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
        // Constant
        if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }


        if (buttonCounter == 1) {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            effect.SetActive(false);
            effect2.SetActive(false);
            creature1.SetActive(true);
            creature2.SetActive(false);
            creature3.SetActive(false);
            creature4.SetActive(false);

        }

        if (buttonCounter == 2)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            effect.SetActive(false);
            effect2.SetActive(false);
            audio1.Play();

            creature1.SetActive(false);
            creature2.SetActive(true);
            creature3.SetActive(false);
            creature4.SetActive(false);

        }

        if (buttonCounter == 3)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(true);
            dialog4.SetActive(false);

            

            effect.SetActive(true);
            effect2.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(true);
            creature4.SetActive(false);

        }

        if (buttonCounter == 4)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
            creature4.SetActive(true);



            effect.SetActive(false);
            effect2.SetActive(true);

        }

        if (buttonCounter > 4)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(false);
            effect.SetActive(false);
            effect2.SetActive(false);

            creature1.SetActive(false);
            creature2.SetActive(false);
            creature3.SetActive(false);
            creature4.SetActive(true);

            continueButton.SetActive(true);
            buttonCounter = 5;

        }
    }
    }
