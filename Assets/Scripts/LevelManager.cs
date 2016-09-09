using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public bool showCursor = false;

	// Use this for initialization
	void Start () {
		Cursor.visible = showCursor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
