﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "sprite0playerf1[1]")
        {
            Debug.Log("Coin collected!");
            Destroy(gameObject);
            Player.collectCoin(1);
        }
    }
}
