using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {
	public float speed;
	Speed spee = new Speed ();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed = spee.GetSpeed();
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}
}
