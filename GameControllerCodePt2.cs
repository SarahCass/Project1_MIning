using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool threeSecondAlert;
    int bronzeOre;
    int silverOre;
    float miningSpeed;
    float miningNow;
    int bronzeSupply;
    int silverSupply;


    // Start is called before the first frame update
    void Start()
    {
        threeSecondAlert = true;
        bronzeOre = 0;
        silverOre = 0;
        miningSpeed = 3;
        miningNow = miningSpeed;
        bronzeSupply = 3;
        silverSupply = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > miningNow)
        {
            if (bronzeSupply > 0)
            {
                bronzeOre++;
                bronzeSupply--;

            }
            else if(silverSupply > 0)
            {
                silverOre++;
                silverSupply--;
            }
            miningNow += miningSpeed;
            print("Bronze:"+bronzeOre+" Silver:"+silverOre);
        }
        
    }
}
