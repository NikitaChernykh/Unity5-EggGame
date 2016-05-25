using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	private float speed;
	Speed spee = new Speed ();//declare speed

	Vector3 left = new Vector2(-4.85f,0);
	Vector3 rigth = new Vector2(4.85f,0);
	private int line;
	void Start () {
		speed = spee.GetSpeed();

		SwipeHandler oySwipe = new SwipeHandler();//start swipes need to check
	}
	void OnSwipeRight()//span swipe right
	{
		if (line == 3) {
			//do nothing
		} else {
			var playerPosition = this.transform.position;
			this.transform.position = rigth;
			this.transform.position = playerPosition + rigth;
		}



	}
	void OnSwipeLeft()//span swipe left
	{
		if (line == 1) {
			//do nothing
		} else {
			var playerPosition = transform.position;
			this.transform.position = left;
			this.transform.position = playerPosition + left;
		}

	}
	void Update(){
		//line counter
		if(this.transform.position.x >= 9f && this.transform.position.x <= 10f){
			Debug.Log("line2");
			line = 2;
		}
		if(this.transform.position.x >= 4f && this.transform.position.x <= 5f){
			Debug.Log("line1");
			line = 1;
		}
		if(this.transform.position.x >= 14f && this.transform.position.x <= 15f){
			Debug.Log("line3");
			line = 3;
		}

		//speed down
		this.transform.Translate(Vector3.down * speed * Time.deltaTime);
		var playerPosition = transform.position;

		//move left and rigth(snaps)
		if (Input.GetKeyDown ("left") && line !=1) {
			this.transform.position = left;
			if (Input.GetKeyDown ("left")&& line !=1){
				this.transform.position = playerPosition + left;
			}
			else{
				//do nothing
			}
			if (Input.GetKeyDown ("right")&& line !=3) {
				this.transform.position = playerPosition + rigth;
			}
			else{
				//do nothing
			}
		}
		if (Input.GetKeyDown ("right") && line != 3) {
			this.transform.position = rigth;
			if (Input.GetKeyDown ("left")&& line !=1) {
				transform.position = playerPosition + left;
			}else{
				//do nothing
			}
			if (Input.GetKeyDown ("right")&& line != 3) {
				this.transform.position = playerPosition + rigth;
			}else{
				//do nothing
			}
		} else {
			//do nothing
		}
	}
}
