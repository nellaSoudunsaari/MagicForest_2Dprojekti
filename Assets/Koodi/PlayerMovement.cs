using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Hakee CharacterControllerin ja animaattorin
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        // Sivuttainen liike
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Animaattori, hakee milloin pelaaja k‰velee ja n‰ytt‰‰ oikean animaation
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // Hyppymekaniikka
        if (Input.GetButtonDown("Jump"))
        {
            // Hakee milloin pelaaja hypp‰‰ ja n‰ytt‰‰ oikean animaation
            animator.SetBool("IsJumping", true);
            jump = true; 
        }

        // Kyykkymekaniikka
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    // Hakee milloin pelaaja on osunut maahan hypyn j‰lkeen, jotta aikaisempi animaatio voidaan lopettaa
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    // Hakee milloin pelaaja on kyykyss‰ jotta oikea animaatio voidaan n‰ytt‰‰
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    // FixedUpdatea k‰ytet‰‰n t‰ss‰ tilanteessa, jotta p‰ivitys
    // toimisi yht‰aikaisesti Unityn PhysicsEnginen kanssa,
    // t‰llˆin fysiikka suoriutuu paremmin
    private void FixedUpdate()
    {
        // Liikuta hahmoa
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
