using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float torqueAmount = 1;

    Rigidbody2D surferBody;

    // Start is called before the first frame update
    void Start()
    {
        surferBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            surferBody.AddTorque(-torqueAmount);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            surferBody.AddTorque (torqueAmount);
        }
    }
}
