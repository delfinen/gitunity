using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{


    public bool ifbool;
    public int value;

    // Use this for initialization
    void Start()
    {

        // != INTE LIKA MED
        // == lika med
        // > större en
        // < mindre en
        //>= större eller lika med
        //<= mindre eller lika med
        // && = och
        // || = eller 



        if (ifbool == true)
        {
            print("ja");
        }

        else
        {
            print("Nej");
        }
        



    }

    // Update is called once per frame

    void Update()
    {
        if (value == 5)
        {
            if (ifbool == true)
                print("hejsan");
        }

        else if (value == 4)
        {
            print("mada mada");
        }

        else if (value == 3)
        {
            print("lol");
        }

        else if (value == 2)
        {
            print("haaaraaaaaam");
        }

        else if (value == 1)
        {
            print("minecraftslayer");
        }


        else
        {
            print("tough luck");
        }
        if (Input.GetKey(KeyCode.E))
        {
            print("HEEEELOOOO BOIIIII");
        }
        {

        }
    }
}

