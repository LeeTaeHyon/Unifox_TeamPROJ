using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    private bool slide;

    private Animator myAnimator;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();   
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);

        ResetValues();

    }
    private void HandleMovement(float horizontal)
    {
        if(slide && !this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Slide"))
        {
            myAnimator.SetBool("Slide", true);
        }
        else if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Slide"))
        {
            myAnimator.SetBool("Slide", false);
        }
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            slide = true;
        }
    }

    private void ResetValues()
    {
        slide = false;
    }

}