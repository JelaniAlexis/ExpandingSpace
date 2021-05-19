using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteShmoovement : MonoBehaviour
{
    public GameObject Note;
    public float Speed = -7;
    // Start is called before the first frame update
    void Start()
    {
        Note = GameObject.Find("Note");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
        if(transform.position.x <= -5)
        {
            Destroy(Note);
        }
    }
     
}
