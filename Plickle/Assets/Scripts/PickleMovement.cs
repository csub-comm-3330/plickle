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
            // rigid body will have go along the forward axis multiple by force in an impulse
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
            // change the bool to saying it has launched
            pickleHasLaunched = true;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
