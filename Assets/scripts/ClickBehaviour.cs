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
}
