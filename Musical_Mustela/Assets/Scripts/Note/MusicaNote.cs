using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote : MonoBehaviour
{
    public GameObject NoteAries;
    public float Speed = -6;
     
    // Start is called before the first frame update
    void Start()
    {
        NoteAries = GameObject.Find("UI_Eerste_schetsen_buttons_Aries_01");
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
