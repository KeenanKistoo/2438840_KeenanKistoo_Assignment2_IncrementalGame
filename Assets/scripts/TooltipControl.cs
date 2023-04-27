using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TooltipControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Tooltip Obj:")]
    public GameObject tooltip;

    [Header("Tooltip Info:")]
    public string upgradeName;
    public string baseMult;
    public string currMult;
    public string totalUpgrade;

    [Header("UI Elements:")]
    public Text upgradeText;
    public Text baseMultText;
    public Text currMultText;
    public Text totalUpgradeText;

    [Header("Upgrade Script:")]
    public Upgrade upgrade;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.SetActive(true);
        upgradeText.text = upgradeName;
        baseMultText.text = "Base Multiplier: " + baseMult + " coins per second";
        currMultText.text = "Total Multiplier: " + upgrade.thisMulti + " coins per second";
        totalUpgradeText.text = "Total Upgrades Completed: " + 'x' + upgrade.lvlCount;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.SetActive(false);
        upgradeText.text = "";
        baseMultText.text = "";
        currMultText.text = "";
        totalUpgradeText.text = "";
    }
}
