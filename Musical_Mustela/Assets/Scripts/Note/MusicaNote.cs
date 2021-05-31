using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote : MonoBehaviour
{

    //Instantiating Game Object
    public GameObject NoteAries;
    //Travelling speed of the note

    public float Speed = -8;
    // Start is called before the first frame update
    void Start()
    {
    }

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
