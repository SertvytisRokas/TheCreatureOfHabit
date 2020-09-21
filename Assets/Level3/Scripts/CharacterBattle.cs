using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{

    private Animator animator;
    private Transform transform;
    private Vector3 slideTargetPosition;
    

    

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float slideSpeed = 10f;
            transform.position += (slideTargetPosition - getPosition()) * slideSpeed * Time.deltaTime;

            float reachedDistance = 1f;
            if (Vector3.Distance(getPosition(), slideTargetPosition) < reachedDistance) {

                transform.position = slideTargetPosition;

            }

        }
       
    }

    public void Attack() { }


    private void SlideToPosition(Vector3 slideTargetPosition) {
        this.slideTargetPosition = slideTargetPosition;
    }

    public Vector3 getPosition() {

        return transform.position;
    }

}
