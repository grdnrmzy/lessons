using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : LootNode 
{
    private List<GameObject> _items = new List<GameObject>();
    void Start()
    {
        _items.ForEach(x => x.SetActive(true));
    }

    // Update is called once per frame
    void Update()
    {
        base.PopulateItem(item);

        _items.Add(item);
        item.SetActive(false);

        
    }
}
