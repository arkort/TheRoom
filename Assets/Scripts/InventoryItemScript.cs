using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItemScript : MonoBehaviour {
    public GameObject Prefab;

    public abstract void Use();

    public void InstantiateActiveItem()
    {
        Instantiate(Prefab, transform);
    }
}
