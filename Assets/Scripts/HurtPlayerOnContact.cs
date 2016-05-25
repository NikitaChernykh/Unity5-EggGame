using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {

	public int damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Egg") {
			LiveManager.HurtPlayer(damage);
			StartCoroutine(DamageBlink(other));

		}
	}
	IEnumerator DamageBlink (Collider2D other) 
	{
			Color color = other.GetComponent<SpriteRenderer>().color;
			other.GetComponent<CircleCollider2D> ().enabled = false;
			for(int i =0;i<3;i++){
				yield return new WaitForSeconds (0.3f);
				color.a = 0;
				other.GetComponent<SpriteRenderer>().color = color;
				yield return new WaitForSeconds (0.3f);
				color.a = 255;
				other.GetComponent<SpriteRenderer>().color = color;
			}
			color.a = 255;
			other.GetComponent<SpriteRenderer>().color = color;
			other.GetComponent<CircleCollider2D> ().enabled = true;

		
	}
}
