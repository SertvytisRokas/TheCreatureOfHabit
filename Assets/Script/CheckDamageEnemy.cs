using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDamageEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bullet;
    public float maxHealth=100f;
    public float bulletDamage = 34f;

    float damageStartTime;

    Renderer renderer;
    Material material;

    public AudioClip audioDie;
    public AudioClip audioHit;

    public GameObject explosion;

    bool isCreated;

    int explosionCounter=0;

    float delay = 0.1f;

    //Animator animator;
    //public Animation anim;
    

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = true;
        material = renderer.material;
        //animator = GetComponent<Animator>();

        

    }

    // Update is called once per frame
    void Update()
    {
        if (damageStartTime != 0)
        {
            float gbColor = (Time.timeSinceLevelLoad - damageStartTime) / 0.5f;

            material.color = new Color(1, gbColor, gbColor, 1);

            if (gbColor > 1)
            {
                damageStartTime = 0;
                material.color = Color.white;
            }
        }

        if (maxHealth <= 0) {
            
        }

        //checkDeath();


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BulletPlayer" ){
            Destroy(collision.gameObject);
            AudioSource audio = GetComponent<AudioSource>();
            if (maxHealth > 0)
            {
                maxHealth -= bulletDamage;
                damageStartTime = Time.timeSinceLevelLoad;
                audio.PlayOneShot(audioHit);
                
            }
            else
            {
                
                audio.PlayOneShot(audioDie);


                spawnAndDestroy(explosion, delay);
                renderer.enabled = false;
                
                
                    
                    Destroy(gameObject, audioDie.length);
                

            }
        }
    }

    void checkDeath() {
        if (maxHealth <= 0) {
            Instantiate(explosion, transform.position, Quaternion.identity);


            explosionCounter++;
            if (explosionCounter > 0)
            {
                CancelInvoke();
            }
        }
    }

    void spawnAndDestroy(GameObject prefab, float del) {
        GameObject newExplosion = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(newExplosion, delay);
    }

    
}
