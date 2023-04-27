using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickBehaviour : MonoBehaviour
{
    [Header("Core Mechanics:")]
    public float clickCount;
    public float clickMultiplier;
    public float click;

    [Header("Display:")]
    public Text clickText;
    public Text multText;

    [Header("Particle Prefab:")]
    public GameObject particles;
    public GameObject parent;
    private void Start()
    {
        clickMultiplier = 0;
        clickCount = 0;
        click = 1;
    }

    private void Update()
    {
         MultiplierCheck();
        MultiplierGrammerCheck();
        multText.text = clickMultiplier.ToString() + " Coins Per Second";
    }

    public void Click()
    {
        clickCount += click;
        
        DecimalControl();
    }

    public void DecimalControl()
    {
       
        if(clickCount > 1000) 
        {
            float totalClicks = clickCount;
            float convClicks = totalClicks;
            clickText.text = (clickCount / 1000).ToString();
        }
        else
        {
            clickText.text = clickCount.ToString();
        }
    }

    public void MultiplierGrammerCheck()
    {
        if(clickMultiplier == 0 || clickMultiplier > 1)
        {
            multText.text = clickMultiplier.ToString() + " coins per second";
        }else if (clickMultiplier == 1)
        {
            multText.text = clickMultiplier.ToString() + " coin per second";
        }
    }

    public void MultiplierCheck()
    {
        
        clickCount += clickMultiplier * Time.deltaTime;
        int clickRound = (int)clickCount;
        clickText.text = clickRound.ToString();
        
    }
}
