using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private UIItem uiItem;
    // Start is called before the first frame update
    void Awake()
    {
        GameEvents.ItemAddedToInventory += AddUIItem;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }

    private void AddUIItem(Item item)
    {
        UIItem uIItemInstance = Instantiate(uiItem, this.transform);
        uIItemInstance.Setup(item);
        Debug.Log("UI got event. ");
    }
}
