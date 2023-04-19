using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehaviour : MonoBehaviour
{
    public int clickCount;
    public int clickMultiplier;

    private void Start()
    {
        clickCount = 0;
    }

    public void Click()
    {
        clickCount += clickMultiplier;
    }
}
