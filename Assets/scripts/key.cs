using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class key : MonoBehaviour {
    

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
            Debug.Log("key collected!");
            Destroy(gameObject);
            Player.haskey = 'y';
        }
    }
}
