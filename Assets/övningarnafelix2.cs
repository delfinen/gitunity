using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class övningarnafelix2 : MonoBehaviour
{


    public int uservalue;
    public int dice1;
    public int dice2;
    public int poang = 10;
    public bool omstart;
    int drakehp;
    int playerhp;
    bool start;
    int drakedoublehpchance;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print(uservalue += 2);


        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            uservalue /= 2;
            print(uservalue);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(uservalue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {   //  randomar 1-6 och sätter  dice 1 till svaret
            dice1 = Random.Range(1, 7);

            // dice2 måste bli slagen först innan den kan ta bort
            dice2 = Random.Range(1, 7);

            // uträkning som tar poang plus dice1 och sedan tar bort med dice2
            poang = poang + dice1 - dice2;
            // printar poangen i consolen
            print(poang);


            if (Input.GetKeyDown(KeyCode.R))
            {

                if (omstart == true)

                    if (poang < 0) 

                print("DU SUGER");
                if (poang > 19)
                    print("nice du suger endå");
            }

            if (start == false)
            {
                drakehp = Random.Range(100, 151);
                playerhp = (100);
                drakedoublehpchance = Random.Range(0, 11);
                print("drakehp" + drakehp);
                print("playerhp" + playerhp);
                start = true;

                if (Input.GetKeyDown(KeyCode.Space))
                {




                }


           



            }
          
          



        }


                      


    }
}
