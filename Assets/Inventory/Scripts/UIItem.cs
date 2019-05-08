using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private TextMeshProUGUI itemNameText;
    private Item item;


    public void Setup(Item item)
    {
        this.item = item;
        Debug.Log(this.item.itemDescription);
        itemNameText.text = item.itemName;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameEvents.OnTooltipActivated(item.itemDescription);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameEvents.OnTooltipDeactivated();
    }
}
