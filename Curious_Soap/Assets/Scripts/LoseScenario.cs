using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScenario : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Game Over");
        }
    }
}
