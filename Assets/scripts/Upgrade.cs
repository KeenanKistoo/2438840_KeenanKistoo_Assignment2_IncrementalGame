using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [Header("Coin Controller:")]
    public ClickBehaviour coinControl;

    [Header("Trackers:")]
    public float costTrack;
    

    public void UpgradeTown()
    {
        
        if(costTrack <= coinControl.clickCount)
        {
            coinControl.clickCount -= costTrack;
            costTrack *= 1.05f;
            print(costTrack);
        }
        else
        {
            print("not enough");
        }
    }

    public void LevelTracker(int upgradeNum)
    {

    }

}
