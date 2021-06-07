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
        HitCircle = GameObject.Find("HitCircle");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, HitCircle.transform.position);
        Debug.Log(distance);
        HitReg();
    }

    public void HitReg()
    {
        if (distance > 0.375f && distance < 0.75f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 50;
        }
        else if (distance > 0.1f && distance < 0.375f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 100;
        }
        else if (distance < 0.1f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.225f);
            ScoringSystem.scoreVal += 250;
        }

        if (distance > 0.375f && distance < 0.75f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 50;
        }
        else if (distance > 0.1f && distance < 0.375f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 100;
        }
        else if (distance < 0.1f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.25f);
            ScoringSystem.scoreVal += 250;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        player.TakeDamage(0.125f);
    }

}
