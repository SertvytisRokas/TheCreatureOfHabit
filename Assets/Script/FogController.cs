using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolumetricFogAndMist;

public class FogController : MonoBehaviour
{

    public VolumetricFog fog;
    

    float fogDensity;

    
    
    // Start is called before the first frame update
    void Start()
    {
        // fogDensity = fog.density;
        
    }

    // Update is called once per frame
    void Update()
    {
       // fog.density = fogDensity;
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player") {
            Destroy(this.gameObject);
            if (this.tag == "Good")
            {
                if (fog.density < 0.3f)
                {
                    fog.density = 0.3f;
                }
                else
                {
                    fog.density -= 0.2f;
                }
            }
            else if (this.tag == "Bad") {
                if (fog.density > 0.9f)
                {
                    fog.density = 0.9f;
                    ;
                }
                else
                {
                    fog.density += 0.2f;
                }
            }
            
            
        }
    }
}
