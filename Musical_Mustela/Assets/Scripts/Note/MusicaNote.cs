using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote : MonoBehaviour
{
    public GameObject Note;
    public float Speed = -7;
     
    // Start is called before the first frame update
    void Start()
    {
        Note = GameObject.Find("UI_Eerste schetsen_buttons_Aries_01");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
         
    }
    void OnBecameInvisible()
    {
        Destroy(Note);
    }
}
