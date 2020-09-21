using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeFightLvl3 : MonoBehaviour
{
    public GameObject cutsceneBackground;

    public void resumeFight() {
        cutsceneBackground.SetActive(false);
    }
}
