using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColDetect : MonoBehaviour
{
    
    
    public float damage;
    private Player player;
    


    public GameObject NoteAries;
    public GameObject HitCircle;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("greenthingy").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(NoteAries.transform.position, HitCircle.transform.position);

        HitReg();
    }

    public void HitReg()
    {
        if (distance > 0.375 && distance < 0.75 && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
        }
        else if (distance > 0.1 && distance < 0.375 && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
        }
        else if (distance < 0.1 && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.25f);
        }

        if (distance > 0.375 && distance < 0.75 && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
        }
        else if (distance > 0.1 && distance < 0.375 && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
        }
        else if (distance < 0.1 && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.25f);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        player.TakeDamage(0.2f);
    }

}
