using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool threeSecondAlert;
    // Start is called before the first frame update
    void Start()
    {
        threeSecondAlert = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3 && threeSecondAlert)
        {
            print("It's been 3 seconds!");
            threeSecondAlert = false;
        }
        
    }
}
