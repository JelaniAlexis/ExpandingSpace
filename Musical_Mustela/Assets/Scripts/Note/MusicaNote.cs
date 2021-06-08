using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote : MonoBehaviour
{

    //Instantiating Game Object
    public GameObject NoteAries;
    //Travelling speed of the note

    public float Speed = -8;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(NoteAries);
    }
}
