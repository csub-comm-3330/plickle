using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleMovement : MonoBehaviour
{
    // add a public variable force allowing us to have a variable force
    public float force = 10;
    // bool that decides whether we have fired
    bool pickleHasLaunched = false;

    // FixedUpdate is use to update for physics
    void FixedUpdate()
    {
        // if the pickle has not launched, then add an impulse force and tell it to say it has launched
        if (!pickleHasLaunched)
        {
            // use rigidbodies and get the rigidebody component to add a force
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
            // change the bool to saying it has launched
            pickleHasLaunched = true;
        }
    }

}
