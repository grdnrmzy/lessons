using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int _weaponChange;
    [SerializeField] private int _armorChange;
    // Start is called before the first frame update
    void Start()
    {
        var item = GetRandomItem();
        PopulteItem(item);
    }

    protected GameObject PopulteItem()
    {
        item.translate.parent = item.transform;
        item.transform.;ocalPosition = Vector3.zero;
    }

    protected GameObject GetRandomItem()
    {
        return new GameObject("Item " + Random.Range(0, 1000));
    }
}
