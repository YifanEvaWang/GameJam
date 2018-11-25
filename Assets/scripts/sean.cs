using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sean : MonoBehaviour {

    public string leveltoload;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(leveltoload);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
