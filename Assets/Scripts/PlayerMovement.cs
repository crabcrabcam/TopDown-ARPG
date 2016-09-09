using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	public float movex;
	public float movey;

	public Vector2 movement;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {

		Movement ();

	}

	void Movement() {

		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");

		movement = new Vector2 (movex, movey);


		if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {

			transform.eulerAngles = new Vector2 (0, 0);
			movex = Input.GetAxis ("Horizontal");
			movey = Input.GetAxis ("Vertical");


			GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * speed, movey * speed);

		}

	}

}
