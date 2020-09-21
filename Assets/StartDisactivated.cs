using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDisactivated : MonoBehaviour
{
  //  public GameObject minimap1;
  //  public GameObject minimap2;
    void Start()
    {
        gameObject.SetActive(false);
   //     minimap1.SetActive(false);
   //     minimap2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
