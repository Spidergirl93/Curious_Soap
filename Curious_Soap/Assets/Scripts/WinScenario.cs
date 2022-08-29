using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScenario : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You won!!!");
        }
    }
}
