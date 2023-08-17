using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;
    bool inContact = false;
    // Start is called before the first frame update
    void Start()
    {
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
                    isOpen = false;
                }
                else
                {
                    animator.Play("DoorOpen");
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
