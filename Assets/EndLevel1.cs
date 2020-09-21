using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel1 : MonoBehaviour
{

    public Text textValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Detector")
        {
            float result;
            string stringValue = textValue.text;
            float.TryParse(stringValue, out result);
            SceneManager.LoadScene("Level1End");
            PlayerPrefs.SetFloat("", result);
            Debug.Log(result);
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
}
