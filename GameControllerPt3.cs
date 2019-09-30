using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool threeSecondAlert;
    // bool noNewGold;

    float miningSpeed;
    float miningNow;

    int bronzeOre;
    int silverOre;
    int goldOre;

    int bronzeSupply;
    int silverSupply;
    int goldSupply;

    //int points;
    int score;

    //int bronzePoints;
    //int silverPoints;
    //int goldPoints;

    public GameObject bronzeCubePrefab;
    Vector3 bronzeCubePosition;
    int xPosBronze;

    public GameObject silverCubePrefab;
    Vector3 silverCubePosition;
    int xPosSilver;

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
        xPosBronze = 0;
        xPosSilver = 0;
        score = 0;
        //goldSupply = 0;
        //noNewGold = true;
    }
    int ScorePoints(int pointsToScore)
    {
        if (pointsToScore == 1)
        {
            print("Way to go! You scored 1 point!");
        }
        else
        {
            print("Way to go! You scored " + pointsToScore + " points!");
        }
        score+= pointsToScore;
        return score;
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

                ScorePoints(1);

                bronzeCubePosition = new Vector3(xPosBronze, 0, 0);
                Instantiate(bronzeCubePrefab, bronzeCubePosition, Quaternion.identity);
                xPosBronze+=2;

            }
            else if (silverSupply > 0)
            {
                silverOre++;
                silverSupply--;

                ScorePoints(10);

                silverCubePosition = new Vector3(xPosSilver, 2, 0);
                Instantiate(silverCubePrefab, silverCubePosition, Quaternion.identity);
                xPosSilver += 2;
            }
            //else if (goldSupply > 0)
            //{
            //    goldOre++;
            //    goldSupply--;
            //    ScorePoints(100);
            //}
            miningNow += miningSpeed;
            print("Bronze:"+bronzeOre+" Silver:"+silverOre);

            //if (bronzeOre==2 && silverOre==2 && noNewGold)
            //{
            //    goldSupply++;
            //    noNewGold = false;
            //}
            //else if (bronzeOre < 4)
            //{
            //    bronzeSupply++;
            //    noNewGold = true;
            //}
            //else if (bronzeOre >= 4)
            //{
            //    silverSupply++;
            //    noNewGold = true;
            //}
        }
        
    }
}
