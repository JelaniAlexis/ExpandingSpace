using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inputs : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("w key was pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("d key was pressed");
        }
    }
}
