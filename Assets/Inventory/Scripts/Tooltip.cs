using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI tooltipText;
    private GameObject tooltip;

    private void Awake()
    {
        tooltip = transform.GetChild(0).gameObject;
        tooltip.SetActive(false);
        GameEvents.TooltipActivated += EnableTooltip;
        GameEvents.TooltipDeactivated += DisableTooltip;
    }

    private void Update()
    {
        if (tooltip.activeSelf)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void EnableTooltip(string text)
    {
        tooltipText.text = text;
        tooltip.SetActive(true);
    }

    public void DisableTooltip()
    {
        tooltipText.text = "null";
        tooltip.SetActive(false);
    }
}
