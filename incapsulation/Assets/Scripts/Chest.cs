using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : LootNode 
{
    private List<GameObject> _items = new List<GameObject>();
    public void Open()
    {
        _items.ForEach(x => x.SetActive(true));
    }

    
   

    protected override GameObject PopulateItem(GameObject item)
    {
        
        _items.Add(item);
        item.SetActive(false);

        return base.PopulateItem(item);
    }
}
