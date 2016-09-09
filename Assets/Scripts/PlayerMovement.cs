using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	public float movex;
	public float movey;

	public Vector3 movement;

	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
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


		if (Input.GetAxisRaw ("Horizontal") != 0 || Input.GetAxisRaw ("Vertical") != 0) {

			movex = Input.GetAxis ("Horizontal");
			movey = Input.GetAxis ("Vertical");

			GetComponent<Rigidbody2D> ().velocity = new Vector3 (movex * speed, movey * speed);

			animator.SetFloat ("Speed", 2);


		

		} else {
			animator.SetFloat ("Speed", 0);
		}

		// Right
		if (Input.GetAxisRaw ("Horizontal") > 0.1) {
			
			transform.eulerAngles = new Vector2 (0, 0);

			//Left
		} else if (Input.GetAxisRaw ("Horizontal") < -0.1) {

			transform.eulerAngles = new Vector2 (0, 180);

			//Up
		} else if (Input.GetAxisRaw ("Vertical") > 0.1) {

			transform.eulerAngles = new Vector2 (0, 90);

			//Down
		} else if (Input.GetAxisRaw ("Vertical") < -0.1) {

			transform.eulerAngles = new Vector2 (0, 270);

			//Right Down
		} else if (Input.GetAxisRaw ("Horizontal") > 0.1 && Input.GetAxisRaw("Vertical") < -0.1) {

			transform.eulerAngles = new Vector2 (0, 0);

			//Left Up
		} else if (Input.GetAxisRaw ("Horizontal") < -0.1 && Input.GetAxisRaw("Vertical") > 0.1) {

			transform.eulerAngles = new Vector2 (0, 0);

			// Right Up
		} else if (Input.GetAxisRaw ("Horizontal") > 0.1 && Input.GetAxisRaw("Vertical") > 0.1) {

			transform.eulerAngles = new Vector2 (0, 0);

			//Left Down
		} else if (Input.GetAxisRaw ("Horizontal") < -0.1 && Input.GetAxisRaw("Vertical") < -0.1) {

			transform.eulerAngles = new Vector2 (0, 0);

		}


	}





}
