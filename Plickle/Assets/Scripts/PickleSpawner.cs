using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleSpawner : MonoBehaviour
{
    //need a prefeab to instantiate
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // set up variable to check to see if the left button is pushed
        bool mouseDown = Input.GetMouseButtonDown(0);
        // if the mouse is down, fire a pickle
        if (mouseDown)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
