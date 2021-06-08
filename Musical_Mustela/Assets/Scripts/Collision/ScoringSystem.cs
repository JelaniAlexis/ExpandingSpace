using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static int scoreVal = 0;
    public static int comboVal = 0;

    Text text;

    // Start is called before the first frame update
    void Start()
    {
            text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Score"))
        {
            text.text = "Score: " + scoreVal;
        }
        else
        {
            text.text = "Combo: " + comboVal;
        }
    }
}
