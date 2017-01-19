using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        if (Input.GetKey(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                var usableScript = hit.collider.GetComponent<IUsableItem>();

                if (usableScript != null)
                {
                    GUI.Label(new Rect(0, 0, 200, 200), "ALEEEE", new GUIStyle() { fontSize = 44 });
                }
            }
        }
    }
}
