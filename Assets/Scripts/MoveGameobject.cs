using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameobject : MonoBehaviour
{
    public float speed = 1.0f; // Adjust the speed as needed

    void Update()
    {
        // Check if the "W" key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            // Move the GameObject forward based on the speed
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
