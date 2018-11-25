using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour {
   [SerializeField] private string LoadLevel;
    

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(LoadLevel);
                    
        }
    }

}
