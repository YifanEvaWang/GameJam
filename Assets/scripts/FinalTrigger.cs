using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour {
    public string levelToLoad;

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "sprite0playerf1[1]")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }

}