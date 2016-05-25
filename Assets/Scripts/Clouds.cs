using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clouds : MonoBehaviour {
	public float speed;
	Vector3 startPosition;
	public bool animationOver = false;
	public float timeLeft;
	private float newTime;

	// Use this for initialization
	void Start () {
		newTime = timeLeft;
		startPosition = transform.position;
	}
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed;

		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			animationOver = true;
			timeLeft = newTime;
		}
		if(animationOver == true){
			transform.position = startPosition;
			animationOver = false;
		}

	}
}
