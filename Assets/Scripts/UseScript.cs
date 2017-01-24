using UnityEngine;

public class UseScript : MonoBehaviour
{
    public AudioSource UseSound;
    public float Distance;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Distance))
        {
            var usableScript = hit.collider.GetComponent<IUsableItem>();

            if (usableScript != null)
            {
                var size = 200;

                var style = new GUIStyle() { fontSize = 26, alignment = TextAnchor.LowerCenter };
                style.normal.textColor = Color.white;

                GUI.Label(new Rect(
                    Screen.width / 2 - size / 2,
                    Screen.height - 50 - size,
                    size,
                    size), "Press E to use", style);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    UseSound.Play();
                    usableScript.Use();
                }
            }
        }
    }
}
