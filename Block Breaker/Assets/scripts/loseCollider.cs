﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseCollider : MonoBehaviour {

    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision Happened with " + collision.gameObject.name);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        myLevelManager.LoadLevel("lose");
    }

    // Use this for initialization
    void Start () {
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
