using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleAim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // defines camera and tells it to get info from the camera
        Camera pickleCamera = GetComponent<Camera>();
        // sets a ray variable that is a screenpoint to ray using the mouse position on the camera
        Ray aimPickle = pickleCamera.ScreenPointToRay(Input.mousePosition);
        // drawing a ray along the variable with the origin and direction of the mouse input
        Debug.DrawRay(aimPickle.origin, aimPickle.direction, Color.magenta);
    }
}
