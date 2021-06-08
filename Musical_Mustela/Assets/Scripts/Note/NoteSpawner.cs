using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NoteSpawner : MonoBehaviour
{
    //Instantiating Game Object
    public GameObject Note;
    //Instantiate cooldown float
    public float Cooldown;
    //Instantiate canvas for text
    public Transform Canvas;

    void Update()
    {
        Cooldown = Random.Range(1.0f, 2.5f);
    }
    //Instantiate function to spawn the note
    private void SpawnTheNote()
    {
        GameObject NoteSpawner = Instantiate(Note) as GameObject;
        NoteSpawner.transform.SetParent(Canvas);
        NoteSpawner.transform.position = new Vector2(8, 2.4318f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("TextCanvas").transform;
        StartCoroutine(CreateNewNote());
    }
    IEnumerator CreateNewNote()
    {
        while (true)
        {
            yield return new WaitForSeconds(Cooldown);
            SpawnTheNote();
        }
    }
}
