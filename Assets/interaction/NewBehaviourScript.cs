using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


    public GameObject TextBox;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public int ChoiceMade;

    private Button choice1;
    private Button choice2;
    private Button choice3;
    private Button choice4;

    

    public void ChoiceOption1()
        

    {
        TextBox.GetComponent<Text>().text = "Choice 1"  ;
        ChoiceMade = 1;


    }
    public void ChoiceOption2()

    {
        TextBox.GetComponent<Text>().text = "Choice 2";
        ChoiceMade = 2;


    }
    public void ChoiceOption3()

    {
        TextBox.GetComponent<Text>().text = "Choice 3";
        ChoiceMade = 3;

    }

    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice1.SetActive(false);
            Choice2.SetActive(false);
            Choice3.SetActive(false);
        }


    }
   
}
