using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderHack : MonoBehaviour
{
    // THIS SCRIPT FORCES CHARACTER CONTROLLERS TO ALLOW A SLOPE LIMIT OF 89 DEGREES - RECOMMEND USING SLOPES OF 85 DEGREES ON LADDERS FOR A REASONABLE CLIMB RATE.
    // NOTE THAT IT IS ONLY THE COLLIDER THAT NEEDS TO BE AT THIS ANGLE, SO A COLLIDER OFFSET FROM ITS RENDERED MESH CAN WORK FINE.

    // VARIABLES

    public CharacterController charController;
    private float initialSlopeLimit;


    void Start()
    {
        initialSlopeLimit = charController.slopeLimit;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            charController.slopeLimit = 89; // VALUE NOT EXPOSED, AS THE CLOSER THIS IS TO 90, THE BETTER.
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            charController.slopeLimit = initialSlopeLimit;
        }
    }
}
