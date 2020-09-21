using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarratorController : MonoBehaviour
{

    public GameObject image1;
    public GameObject image2;
    public AudioSource audio1;
    public AudioSource audio2;

    int counter=0;
    float timer = 0;

    void Start()
    {
        image1.SetActive(true);
        image2.SetActive(false);
    }

    
    void Update()
    {
        clock();
        controller1();

    }

    void clock() {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            counter++;
        }
    }

    void controller1() {
        int counterFake = counter ;
        timer += Time.deltaTime;

        while (audio1.isPlaying) {
            counter = 1;

        }
        while (!audio1.isPlaying && counter>1) {
            timer = 0;
            audio2.Play();
            image1.SetActive(false);
            image2.SetActive(true);
            if (!audio2.isPlaying && Input.GetKeyDown(KeyCode.RightArrow)) {
                SceneManager.LoadScene("Intro2");
            }
        }




        /*
        if (counter <0  && !audio1.isPlaying) {
            image1.SetActive(false);
            image2.SetActive(true);
            counterFake = counter;
        }
        else if(counterFake>counter)*/
    }

    
}
