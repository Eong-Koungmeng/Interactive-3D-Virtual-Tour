using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    [SerializeField] PlayerMovement movement;
    private float cameraHeightOffset;
    [SerializeField] private Camera targetCamera;
    private float cameraHeight;
    private bool automated;

    private void Awake()
    {
        cameraHeightOffset = transform.position.y - player.position.y;

        if(StateTransfer.tourType == "AutomatedTour")
        {
            automated = true;
        }
    }

    private void LateUpdate()
    {
        //Make camera position.x and z same with player
        //Camera follows player
        if (automated || movement.isGrounded)
        {
            cameraHeight = cameraHeightOffset + player.position.y;
        }

        transform.position = new Vector3(player.position.x, cameraHeight, player.position.z);

        //Keep the same rotation for x and y and change y to match player rotation
        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
