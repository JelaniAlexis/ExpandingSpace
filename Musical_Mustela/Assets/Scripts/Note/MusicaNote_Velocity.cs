using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote_Velocity : MonoBehaviour
{

    //Instantiating Game Object
    public GameObject NoteAries;

    Rigidbody2D NoteRB;
    //Travelling speed of the note
    public float Speed = -250;
    // Start is called before the first frame update
    void Start()
    {
        NoteRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        NoteRB.velocity = new Vector2(Speed, 0) * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(NoteAries);
    }
}
