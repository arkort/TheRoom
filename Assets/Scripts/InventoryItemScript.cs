using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItemScript : MonoBehaviour {
    public GameObject Prefab;

    public abstract void Use();

    public GameObject InstantiateActiveItem(Transform parentCamera)
    {
        return Instantiate(Prefab, parentCamera.parent.position + new Vector3(0,0,-1), new Quaternion(0, 0, 0 , 0), parentCamera);
    }
}
