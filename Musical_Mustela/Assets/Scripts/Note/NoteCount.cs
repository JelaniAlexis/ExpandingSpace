using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCount : MonoBehaviour
{
    //Initialising ints for the Sprite change
    public static int PerfectAmount;
    public static int GreatAmount;
    public static int GoodAmount;
    public static int YouSuck;

    //Initialising sprites for the Sprite change
    public Sprite AmazedFerret;
    public Sprite HappyFerret;
    public Sprite AnnoyedFerret;
    public Sprite EnragedFerret;

    // Update is called once per frame
    void Update()
    {
        if (PerfectAmount > GreatAmount && PerfectAmount > GoodAmount && PerfectAmount > YouSuck)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = AmazedFerret;
        }

        if (GreatAmount > PerfectAmount && GreatAmount > GoodAmount && GreatAmount > YouSuck)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HappyFerret;
        }

        if (GoodAmount > PerfectAmount && GoodAmount > GreatAmount && GoodAmount > YouSuck)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HappyFerret;
        }

        if(YouSuck > PerfectAmount && YouSuck > GreatAmount && YouSuck > GoodAmount)
        {
             if (YouSuck < 3)
             {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = AnnoyedFerret;
             }

             else
             {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = EnragedFerret;
             }
              
        }
    }
}
