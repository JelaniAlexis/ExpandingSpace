using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNote_Velocity : MonoBehaviour
{

    //Instantiating Game Object
    public GameObject NoteAries;
    //Instantiating Rigidbody2D
    Rigidbody2D NoteRB;
    //Instantiating Sprite Renderer
    SpriteRenderer NoteRend;
    //Travelling speed of the note
    public float Speed = -350;
    // Start is called before the first frame update
    void Start()
    {
        NoteRB = GetComponent<Rigidbody2D>();
        NoteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        NoteRB.velocity = new Vector2(Speed, 0) * Time.deltaTime;

    }

    IEnumerator Blipper()
    {
        for (float f = 0.5f; f >= -0.05f; f -= 0.05f)
        {
            Color NoteColor = NoteRend.material.color;
            NoteColor.a = f * 2;
            NoteRend.material.color = NoteColor;
            yield return new WaitForSeconds(0.025f);
            if(f <= 0)
            {
                Debug.Log("Pork in New York is goated");
                Destroy(gameObject);
            }
             
        }

         
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(Blipper());
    }
}
