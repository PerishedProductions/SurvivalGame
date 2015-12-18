using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item{

    public int itemID;
    public string itemName;
    public string itemDesc;

    public Item(int id, string name, string desc)
    {
        this.itemID = id;
        this.itemName = name;
        this.itemDesc = desc;
    }

}
