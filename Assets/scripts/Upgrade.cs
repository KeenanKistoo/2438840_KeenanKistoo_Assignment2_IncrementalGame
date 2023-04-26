using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [Header("Scripts:")]
    public ClickBehaviour coinControl;
    public LevelController lvlControl;

    [Header("Trackers:")]
    public float costTrack;
    public int lvlArray;

    [Header("UI Elements:")]
    public Text costText;
    public Text lvlText;

    private void Start()
    {
        SetUp();
    }

    public void UpgradeTown()
    {
        
        if(costTrack <= coinControl.clickCount)
        {
            coinControl.clickCount -= costTrack;
            //costTrack *= 1.05f;
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

    public void SetUp()
    {
        costText.text = costTrack.ToString();
        lvlText.text = "X" + lvlControl.upgradeLevel[lvlArray].ToString();
    }
}
