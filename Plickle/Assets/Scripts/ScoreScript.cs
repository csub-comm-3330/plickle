using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // once the pickle hits the koolaid, you score a point
    private void OnTriggerEnter(Collider other)
    {
        print("Score!");
        ScoreCounter.scoreValue += 1;
    }
}
