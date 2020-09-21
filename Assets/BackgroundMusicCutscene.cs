using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicCutscene : MonoBehaviour
{
    /*
    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("CutsceneMusic");
        if (objects.Length > 1) {
            Destroy(this.gameObject);
        }

        Debug.Log(objects.Length);
        DontDestroyOnLoad(this.gameObject);
    }
    */

    private void Update()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("CutsceneMusic");
        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }


}
