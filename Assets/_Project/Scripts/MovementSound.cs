using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{
    PlayerMovement movement;
    [SerializeField] AudioSource footstepsSound, sprintSound, jumpSound;

    void Start()
    {
        movement = GetComponent<PlayerMovement>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(movement.isGrounded && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D)))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                jumpSound.enabled = false;
                footstepsSound.enabled = false;
                sprintSound.enabled = true;

            }
            else
            {
                jumpSound.enabled = false;
                sprintSound.enabled = false;
                footstepsSound.enabled = true;
            }
        }
        else if(Input.GetKey(KeyCode.Space)|| !movement.isGrounded)
        {
            jumpSound.enabled = true;
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
        else
        {
            jumpSound.enabled = false;
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
    }
}
