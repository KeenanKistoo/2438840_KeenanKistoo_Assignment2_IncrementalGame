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
    public bool road;
    public int basicCount;


    [Header("UI Elements:")]
    public Text costText;
    public Text lvlText;

    [Header("Directory Control")]
    public GameObject dirOne;
    public GameObject dirTwo;
    public GameObject parent;
    public GameObject homeObj;
    int upgradeCount;
    public int population;
    public int dayVisitors;
    

    
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
            lvlControl.pop += population;
            lvlControl.day += dayVisitors;
            Directory();
            
        }
        else
        {
            print("not enough");
            
        }
    }

    public void LevelTracker(int upgradeNum)
    {
        lvlControl.upgradeLevel[upgradeNum] += 1;
        upgradeCount = upgradeNum;
    }

    public void SetUp()
    {
        costText.text = costTrack.ToString();
        lvlCount = 0;
        basicCount = 0;
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

    public void ImageTrack(int num)
    {
        if(num == 0) //Apartment
        {
            lvlControl.apartment[lvlControl.tab2].SetActive(true);
            lvlControl.mall[lvlControl.tab2].SetActive(false);
            lvlControl.stadium[lvlControl.tab2].SetActive(false);
            lvlControl.hospital[lvlControl.tab2].SetActive(false);
        }else if(num == 1) //mall
        {
            lvlControl.apartment[lvlControl.tab2].SetActive(false);
            lvlControl.mall[lvlControl.tab2].SetActive(true);
            lvlControl.stadium[lvlControl.tab2].SetActive(false);
            lvlControl.hospital[lvlControl.tab2].SetActive(false);
            print(num);
        }
        else if(num == 2) //stadium
        {
            lvlControl.apartment[lvlControl.tab2].SetActive(false);
            lvlControl.mall[lvlControl.tab2].SetActive(false);
            lvlControl.stadium[lvlControl.tab2].SetActive(true);
            lvlControl.hospital[lvlControl.tab2].SetActive(false);
        }
        else if(num == 3) //hospital
        {
            lvlControl.apartment[lvlControl.tab2].SetActive(false);
            lvlControl.mall[lvlControl.tab2].SetActive(false);
            lvlControl.stadium[lvlControl.tab2].SetActive(false);
            lvlControl.hospital[lvlControl.tab2].SetActive(true);
        }
    }

    public void Directory()
    {
        if (basic && !road)
        {
            lvlControl.structCount++;
            if(lvlControl.structCount == 20)
            {
                //GameObject directory = Instantiate(dirOne);
                //directory.transform.SetParent(parent.transform, false);
                lvlControl.inactiveOne[lvlControl.tab].SetActive(true);
                StartCoroutine(NumberCheck());
                

            }
        }else if(!basic && !road)
        {
            //GameObject directoryTwo= Instantiate(dirTwo);
            //directoryTwo.transform.SetParent(parent.transform, false);
            lvlControl.inactiveTwo[lvlControl.tab2].SetActive(true);
            lvlControl.tab2 += 1;


        }
    }

    IEnumerator NumberCheck()
    {
        yield return new WaitForSeconds(0.5f);

        lvlControl.homeInactive[lvlControl.tab].text = "X" + lvlControl.upgradeLevel[0].ToString();
        lvlControl.shopInactive[lvlControl.tab].text = "X" + lvlControl.upgradeLevel[1].ToString();
        lvlControl.foodInactive[lvlControl.tab].text = "X" + lvlControl.upgradeLevel[2].ToString();
        lvlControl.schoolInactive[lvlControl.tab].text = "X" + lvlControl.upgradeLevel[4].ToString();
        lvlControl.structCount = 0;
        lvlControl.tab += 1;
    }
}
