using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleAim : MonoBehaviour
{

    // public method and put our information into public
    public Ray GetRay()
    {
        // defines camera and tells it to get info from the camera
        Camera pickleCamera = GetComponent<Camera>();
        // sets a ray variable that is a screenpoint to ray using the mouse position on the camera
        Ray aimPickle = pickleCamera.ScreenPointToRay(Input.mousePosition);
        // drawing a ray along the variable with the origin and direction of the mouse input
        Debug.DrawRay(aimPickle.origin, aimPickle.direction, Color.magenta);
        return aimPickle;
    }
}
