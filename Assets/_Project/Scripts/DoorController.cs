using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    [SerializeField]AudioSource doorOpenSound;
    [SerializeField]AudioSource doorCloseSound;
    bool isOpen = false;
    bool inContact = false;
    // Start is called before the first frame update
    void Start()
    {
        doorCloseSound.volume = StateTransfer.volume / 100;
        doorOpenSound.volume = StateTransfer.volume / 100;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inContact) 
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(isOpen)
                {
                    animator.Play("DoorClose");
                    doorCloseSound.Play();
                    isOpen = false;
                }
                else
                {
                    animator.Play("DoorOpen");
                    doorOpenSound.Play();
                    isOpen = true;
                }
            }
        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inContact = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inContact = false;
    }
}
