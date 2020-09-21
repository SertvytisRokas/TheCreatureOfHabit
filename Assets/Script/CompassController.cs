using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassController : MonoBehaviour
{
    public GameObject compassCanvas;
    private bool hasCoroutineStarted = false;

    void Start()
    {
        
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {

            hasCoroutineStarted = true;
            

            



            compassCanvas.SetActive(true);
            Destroy(this.gameObject);
            

        }
        StartCoroutine(waitAndDestroy());
    }

    IEnumerator waitAndDestroy() {
        
        //while (true) {
            yield return new WaitForSeconds(10);
            compassCanvas.SetActive(false);
       // }

        
    }

}
