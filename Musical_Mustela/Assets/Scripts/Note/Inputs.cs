using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inputs : MonoBehaviour
{

    public GameObject Note;
    void Start()
    {
        Note = GameObject.Find("UI_Eerste schetsen_buttons_Aries_01");
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("w key was pressed");
            Destroy(Note);
        }

        if (Input.GetKeyDown("d"))
        {
            Debug.Log("d key was pressed");
        }
    }
}