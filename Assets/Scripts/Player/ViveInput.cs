using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    public SteamVR_Action_Single squeezeAction;
    public SteamVR_Action_Vector2 touchpadAction;

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input._default.inActions.Teleport.GetStateUp(SteamVR_Input_Sources.Any))
        {
            Debug.Log("Touchpad Click Action ~~~~~~~~~~~~~~~~~~~~~~>>>");
        }

        if (SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.Any) >= 0.02f)
        {
            Debug.Log("<<<<<<<<<<<<<<<<<<< Trigger Squeezed Action ~~~~~>>>");
        }

    }
}
