using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasure : MonoBehaviour {

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
            Debug.Log("100 coins collected!");
            Destroy(gameObject);
            Player.collectCoin(100);
        }
    }
}
