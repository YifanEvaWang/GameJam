using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;
    Animator anim;
    static int coinAmount = 0;
    public static char haskey = 'N';


    private Vector2 direction;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetInput();
        Move();	
	}

    public void Move()
    {
        transform.Translate(direction*speed*Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

    public static void collectCoin(int amount)
    {

        scoreScript.coinAmount += amount;
        scoreScript.coinAmount++;
        Debug.Log("You have " + coinAmount + " coins right now");
    }
}
