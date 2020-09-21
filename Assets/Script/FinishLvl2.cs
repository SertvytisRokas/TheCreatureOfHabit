using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLvl2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Debug.Log("Kas viksta");
            SceneManager.LoadScene("Level2Win");
        }
    }


}
