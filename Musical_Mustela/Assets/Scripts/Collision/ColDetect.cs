using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColDetect : MonoBehaviour
{


    public float damage;
    public int combo;
    private Player player;

    public GameObject NoteAries;
    public GameObject HitCircle;
    public GameObject ScoreCanvas;
    public Transform ScoreText;

    public float distance;
    public bool inrange;

    public int antiInsta;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("greenthingy").GetComponent<Player>();
        HitCircle = GameObject.Find("HitCircle");
        inrange = false;
        antiInsta = 0;
        ScoreText = GameObject.Find("Canvas2").transform.Find("ScoreText");
    }

    private void ScoreDisp(int gained)
    {
        ScoreText.transform.position = new Vector3(0.17f, 2.34f, 3);

        switch (gained)
        {
            case 100:
                ScoreText.GetComponent<Text>().text = "Good!";
                break;
            case 150:
                ScoreText.GetComponent<Text>().text = "Great!";
                break;
            case 250:
                ScoreText.GetComponent<Text>().text = "Perfect!";
                break;
        }
    }

    public void HitReg()
    {
        if (distance > 0.375f && distance < 0.8f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 100;
            ScoreDisp(100);
            ScoringSystem.comboVal += 1;
        }
        else if (distance > 0.1375f && distance < 0.375f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 150;
            ScoreDisp(150);
            ScoringSystem.comboVal += 1;
        }
        else if (distance < 0.1375f && Input.GetKeyDown("a") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.225f);
            ScoringSystem.scoreVal += 250;
            ScoreDisp(250);
            ScoringSystem.comboVal += 1;
        }

        if (distance > 0.375f && distance < 0.8f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Good Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 100;
            ScoreDisp(100);
            ScoringSystem.comboVal += 1;
        }
        else if (distance > 0.1375f && distance < 0.375f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Great Range");
            Destroy(NoteAries);
            player.HealingUp(0.1f);
            ScoringSystem.scoreVal += 150;
            ScoreDisp(150);
            ScoringSystem.comboVal += 1;
        }
        else if (distance < 0.1375f && Input.GetKeyDown("d") && NoteAries)
        {
            Debug.Log("Perfect Range");
            Destroy(NoteAries);
            player.HealingUp(0.25f);
            ScoringSystem.scoreVal += 250;
            ScoreDisp(250);
            ScoringSystem.comboVal += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, HitCircle.transform.position);
        if (distance < 0.1f)
        {
            inrange = true;
        }
        if (distance > 0.8f)
        {
            if (inrange == true && antiInsta < 1)
            {
                player.TakeDamage(0.125f);
                ScoringSystem.comboVal = 0;
                antiInsta++;
            }
        }
        HitReg();
    }
}