using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class S4Dialog : MonoBehaviour
{

    public GameObject dialog1;
    public GameObject dialog2;
    public VideoPlayer video;

    public GameObject continueButton;

    int buttonCounter;
    float timer = 0;

    double time;
    double currentTime;

    void Start()
    {
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        time = video.clip.length;
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
        try
        {
            // Constant
            if (buttonCounter < 0)
        {
            buttonCounter = 0;
        }


        if (buttonCounter == 1)
        {
            dialog1.SetActive(true);
            dialog2.SetActive(false);
            video.enabled = false;
        }

        

        if (buttonCounter == 2)
        {
            
                timer += Time.deltaTime;
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                video.enabled = true;
                video.Play();



                if (timer >= 2f)
                {
                    Destroy(video);
                }
            
            
        }
        if (buttonCounter == 3)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
            video.enabled = false;
        }
            if (buttonCounter > 3) {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                continueButton.SetActive(true);
            }
        }
        catch (System.Exception e) { }
    }


        }
