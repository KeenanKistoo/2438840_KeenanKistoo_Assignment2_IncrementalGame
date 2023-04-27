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
    public int lvlCount;
    public bool basic;
    public int basicCount;

    [Header("UI Elements:")]
    public Text costText;
    public Text lvlText;

    [Header("Directory Control")]
    public GameObject dirOne;
    public GameObject dirTwo;
    public GameObject parent;

    
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
            lvlCount += 1;
            lvlText.text = 'X' + lvlCount.ToString();
            Directory();
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
        lvlCount = 0;
        basicCount = 19;
        lvlText.text = "X" + lvlCount.ToString();
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

    public void Directory()
    {
        if (basic)
        {
            basicCount++;
            print(basicCount);

            if(basicCount == 20)
            {
                GameObject directory = Instantiate(dirOne);
                directory.transform.SetParent(parent.transform, false);
                //directory.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            }
        }
    }
}
