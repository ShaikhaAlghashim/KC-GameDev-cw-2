using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class Cw2 : MonoBehaviour
{
    string heroname = "The FLASH";
    int heropower = 200;
    //
    string VillainName = "Shadow";
    int VillainPower = 180;
    float playerspeed = 2.7f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower >= VillainPower)
        {
            print("heroPower stronger than VillainPower");
        }
        else if (heropower < VillainPower)
        {
            print("VillainPower stronger than heroPower");
        }
        SetSpeed(2.5F);
    }

    // Update is called once per frame
    void Update()
    {


    }



    void SetSpeed(float speed) 
    {
        playerspeed = speed;
    }
    void CompareSpeed(float speed1 , float speed2)
    {
        if (speed1 > speed2) 
        {
            print("speed1 is festest than speed2");
        }
        else if (speed1 < speed2) 
        {
            print("speed2 is fastest than speed1");
        }
        else if (speed1 == speed2) 
        {
            print(speed1 = speed2);
        }
    }
}
