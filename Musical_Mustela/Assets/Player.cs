using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth;
    [SerializeField] public Image healthImage;

    public void TakeDamage(float a) 
    {
        playerHealth -= a;
        healthImage.fillAmount = playerHealth;
    }

   


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
