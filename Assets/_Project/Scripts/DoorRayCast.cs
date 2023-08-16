using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRayCast : MonoBehaviour
{
    [SerializeField] int rayLength = 5;
    [SerializeField] LayerMask layerMaskInteract;

    private DoorController raycastedObj;
}
