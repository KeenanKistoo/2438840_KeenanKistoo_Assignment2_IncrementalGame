using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [Header("Basic Upgrade:")]
    public string[] upgradeName;
    public int[] upgradeLevel;

    [Header("Tracker")]
    public int structCount;
    public int tab;
    public int tab2;
    public int imgCount;

    [Header("Array imgs:")]
    public Sprite[] icons;

    [Header("Lists:")]
    public List<GameObject> activeOne = new List<GameObject>();
    public List<GameObject> activeTwo = new List<GameObject>();
    public List<GameObject> inactiveOne = new List<GameObject>();
    public List<GameObject> inactiveTwo = new List<GameObject>();
    public List<Image> activeImage = new List<Image>();
    public List<Image> activePanel = new List<Image>();
    public List<Text> homeActive = new List<Text>();
    public List<Text> homeInactive = new List<Text>();
    public List<Text> shopActive = new List<Text>();
    public List<Text> shopInactive = new List<Text>();
    public List<Text> foodActive = new List<Text>();
    public List<Text> foodInactive = new List<Text>();
    public List<Text> schoolActive = new List<Text>();
    public List<Text> schoolInactive = new List<Text>();

    [Header("Secondary Panel:")]
    public List <GameObject> apartment = new List<GameObject>();
    public List <GameObject> mall = new List<GameObject>();
    public List <GameObject> stadium = new List<GameObject>();
    public List<GameObject> hospital = new List<GameObject>();

    private void Update()
    {
        
    }
}
