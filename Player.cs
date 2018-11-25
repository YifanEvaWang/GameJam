using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;

    private Vector2 direction;

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
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

        AnimateMovement(direction);
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

    public void AnimateMovement(Vector2 direction)
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }
}
