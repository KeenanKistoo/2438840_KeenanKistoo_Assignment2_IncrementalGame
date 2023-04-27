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
    public float buildMulti;
    public float thisMulti;
    public int lvlArray;

    [Header("UI Elements:")]
    public Text costText;
    public Text lvlText;

    
    private void Start()
    {
        SetUp();        
    }

    private void Update()
    {
        AffordCheck();
    }

    public void UpgradeTown()
    {
        
        if(costTrack <= coinControl.clickCount)
        {
            coinControl.clickCount -= costTrack;
            costTrack *= 1.14f;
            int cost = (int)costTrack; //Fix this section.
            costText.text = cost.ToString();
            coinControl.clickMultiplier += buildMulti;
            thisMulti += buildMulti;
            //print(costTrack);
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

    public void AffordCheck()
    {
        if(costTrack <= coinControl.clickCount)
        {
            costText.color = Color.white;
        }
        else
        {
            costText.color = new Color32(116,0,0,255);
        }
    }
}
