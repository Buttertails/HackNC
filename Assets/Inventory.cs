using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name;
    public int amt;

    public Item(string n, int i)
    {
        name = n;
        amt = i;
    }
}

class Inventory : MonoBehaviour
{
    List<ResourceObject> inv = new List<ResourceObject>();

    public void AddItem(ResourceObject item)
    {
        inv.Add(item);
    }

    public void RemoveItem(ResourceObject item)
    {
        inv.Remove(item);
    }
}