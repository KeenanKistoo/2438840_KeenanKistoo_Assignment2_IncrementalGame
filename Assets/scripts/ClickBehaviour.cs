using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickBehaviour : MonoBehaviour
{
    [Header("Core Mechanics:")]
    public float clickCount;
    public float clickMultiplier;

    [Header("Display:")]
    public Text clickText;
    public Text multText;

    private void Start()
    {
        clickCount = 0;
    }

    public void Click()
    {
        clickCount += clickMultiplier;
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

    private void Update()
    {
       MultiplierGrammerCheck();
    }
}
