using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLvl1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            SceneManager.LoadScene("Level1End");
        }
    }





    /*
    if (collision.CompareTag("Player")) {
        float result;
        string stringValue = textValue.text;
        float.TryParse(stringValue, out result);
        SceneManager.LoadScene("Level1End");
        PlayerPrefs.SetFloat("", result);
        Debug.Log(result);
    }
    */

}
