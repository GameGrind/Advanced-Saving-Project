using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItemSet : MonoBehaviour
{
    public HashSet<string> CollectedItems { get; private set; } = new HashSet<string>();

    private void Awake()
    {
        GameEvents.SaveInitiated += Save;
        Load();
    }

    void Save()
    {
        SaveLoad.Save(CollectedItems, "CollectedItems");
    }

    void Load()
    {
        if (SaveLoad.SaveExists("CollectedItems"))
        {
            CollectedItems = SaveLoad.Load<HashSet<string>>("CollectedItems");
        }
    }
}
