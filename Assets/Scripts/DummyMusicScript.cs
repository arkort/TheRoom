using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMusicScript : MonoBehaviour, IUsableItem {

    private AudioSource _audioSource;

    public void Use()
    {
        _audioSource.Play();

        GlobalScript.Instance.TurnLight(false);
    }

    void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}
}
