using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : InventoryItemScript {
    public Light light;

    public override void Use()
    {
        light.enabled = !light.enabled;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
