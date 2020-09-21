using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;

    private void Update()
    {
        if (player.position.x > -7)
        {
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
    }

}
