using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	public float speed;
	private float slowCamSpeed = 0.3f;
	public GameObject newPoint;
	Speed spee = new Speed ();//declare speed

	void Start () {
	}
	void Update() 
	{
		speed = spee.GetSpeed();
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		transform.position = Vector3.Lerp(transform.position,newPoint.transform.position,Time.deltaTime * slowCamSpeed);
	}	

}