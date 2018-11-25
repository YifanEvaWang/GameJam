using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour {

    public static int finishAmount = scoreScript.coinAmount;
    Text score;

    // Use this for initialization
    void Start () {
        score = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Your ending coin balance is: " + finishAmount;
    }
}
