using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*class Inventory : MonoBehaviour
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
}*/

[CreateAssetMenu]

public class DynamicInventory : ScriptableObject
{
	public int cap = 20;
	public List<ResourceObject> items = new();
	
	public bool AddItem(ResourceObject r)
    {
		bool found = false;
		if (items.Count < cap)
		{
			// Finds an empty slot if there is one
			for (int i = 0; i < items.Count; i++)
			{
				if ((items[i].resourceName == r.resourceName) && (items[i].resourceQuantity < cap))
				{
					items[i].resourceQuantity++;
					return true;
				}
				else if (items[i] == null)
				{
					for (int j = 0; j < items.Count && found == false; j++)
					{
						if (items[j] == r)
						{
							found = true;
						}
					}
					if (found == false)
					{
						items[i] = r;
						return true;
					}
				}
			}
		}

        Debug.Log("No space in the inventory");
        return false;
    }
	
	public void RemoveItem(ResourceObject r)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (items[i] == r)
			{
				if (items[i].resourceQuantity > 0)
				{
					items[i].resourceQuantity--;
				}
				else
				{
					items[i] = null;
				}
			}
		}
	}

	/*
	Create a Cap
	Create a base level
	Implement a leveling perk to resource rates of accruing
	 */
}