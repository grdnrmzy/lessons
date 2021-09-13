using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LootNode : MonoBehaviour
{
    [SerializeField] private int _weaponChange;
    [SerializeField] private int _armorChange;
    // Start is called before the first frame update
    void Start()
    {
        var item = GetRandomItem();
        PopulateItem(item);
    }

    protected virtual GameObject PopulateItem(GameObject item)
    {
        item.transform.parent = item.transform;
        item.transform.localPosition = Vector3.zero;
        throw new NotImplementedException();
    }

    protected GameObject GetRandomItem()
    {
        return new GameObject("Item " + Random.Range(0, 1000));

    }

    private void Awake()
    {
        throw new NotImplementedException();
    }
}
