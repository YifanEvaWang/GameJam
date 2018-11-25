using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {
    public void loadSceneByIndex (int index) {
        SceneManager.LoadScene(index);

        SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);

    }
}