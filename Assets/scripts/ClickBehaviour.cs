using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehaviour : MonoBehaviour
{
    public float clickCount;
    public float clickMultiplier;

    private void Start()
    {
        clickCount = 0;
    }

    public void Click()
    {
        clickCount += clickMultiplier;
    }
}
