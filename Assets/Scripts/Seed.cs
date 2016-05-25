using UnityEngine;
using System.Collections;


public class Seed : MonoBehaviour {
	private static int pointsToAdd = 1;
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			ScoreManager.AddPoints(pointsToAdd);
			GetComponent<SpriteRenderer>().enabled = false;
			Destroy(gameObject,1f); //destroy object after 1 sec
		}  

	}
}
