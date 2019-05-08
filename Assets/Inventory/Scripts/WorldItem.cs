using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldItem : MonoBehaviour
{
    [SerializeField]
    private string itemName;
    private ItemDatabase database;
    private CollectibleItemSet collectibleItemSet;
    private UniqueID uniqueID;

    // Start is called before the first frame update
    void Start()
    {
        uniqueID = GetComponent<UniqueID>();
        database = FindObjectOfType<ItemDatabase>();
        collectibleItemSet = FindObjectOfType<CollectibleItemSet>();
        if (collectibleItemSet.CollectedItems.Contains(uniqueID.ID))
        {
            Destroy(this.gameObject);
            return;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectibleItemSet.CollectedItems.Add(uniqueID.ID);
            other.GetComponent<Inventory>().AddItem(itemName);
            Destroy(gameObject);
        }
    }
}
