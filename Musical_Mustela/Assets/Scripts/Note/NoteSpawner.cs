using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NoteSpawner : MonoBehaviour
{
    //Instantiating Game Object
    public GameObject Note;
    //Instantiate cooldown float
    public float Cooldown = 5f;
    //Instantiate function to spawn the note
    private void SpawnTheNote()
    {
        GameObject NoteSpawner = Instantiate(Note) as GameObject;
        NoteSpawner.transform.position = new Vector2(8, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
         
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
