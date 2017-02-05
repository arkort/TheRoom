using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour {

    public AudioSource UseSound;
    public float Distance;

    private Inventory _inventory;
    private InventoryItemScript _currentItem;

    // Use this for initialization
    void Start()
    {
        _inventory = new Inventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if(_currentItem != null)
            {
                _currentItem.Use();
            }
        }
    }

    void OnGUI()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Distance))
        {
            var usableScript = hit.collider.GetComponent<InventoryItemScript>();

            if (usableScript != null)
            {
                var size = 200;

                var style = new GUIStyle() { fontSize = 26, alignment = TextAnchor.LowerCenter };
                style.normal.textColor = Color.white;

                GUI.Label(new Rect(
                    Screen.width / 2 - size / 2,
                    Screen.height - 50 - size,
                    size,
                    size), "Press E to take", style);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    UseSound.Play();
                    _inventory.AddToInventory(usableScript);
                    if(_currentItem == null)
                    {
                        _currentItem = usableScript;
                        _currentItem.InstantiateActiveItem(Camera.main);
                    }
                    Destroy(usableScript.gameObject);
                }
            }
        }
    }
}
