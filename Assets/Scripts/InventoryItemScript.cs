using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItemScript : MonoBehaviour {
    public GameObject Prefab;

    public abstract void Use();

    public GameObject InstantiateActiveItem(Camera parentCamera)
    {
        var obj = Instantiate(Prefab, parentCamera.transform.position, parentCamera.transform.rotation * Quaternion.Euler(180,270,0), parentCamera.transform);

        obj.transform.localPosition = new Vector3(0.1f, -0.1f, 0.3f);

        return obj;
    }
}
