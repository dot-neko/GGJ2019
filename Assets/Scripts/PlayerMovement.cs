using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float runSpeed = 40f;
    public CharMovement character;
    public Animator animator;
    public AudioSource audio;
    float HorizontalMove = 0f;
    bool jump = false;
    bool crouch = false; 

    // Update is called once per frame
    void Update ()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Paso", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Saltando", true);
            animator.SetFloat("Paso",0f);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    
    public void OnLanding ()
    {
        animator.SetBool("Saltando", false);
        audio.Play();   
    }
    public void OnCrouching (bool Agachandose)
    {
        animator.SetBool("Agachandose", Agachandose);
    }
    void FixedUpdate()
    {
        character.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
