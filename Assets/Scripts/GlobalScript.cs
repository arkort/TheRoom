using UnityEngine;

public class GlobalScript {
    private static GlobalScript _instance;

    public static GlobalScript Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GlobalScript();
            }

            return _instance;
        }
    }

    private Light _globalLight;

    public Light GlobalLight
    {
        get
        {
            if(_globalLight == null)
            {
                _globalLight = GameObject.FindObjectsOfType<Light>()[0];
            }
            return _globalLight;
        }
    }

    public void TurnLight(bool mode)
    {
        GlobalLight.enabled = mode;
    }
}
