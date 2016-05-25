using UnityEngine;
using System.Collections;

public class OkbtnPressed : MonoBehaviour {
	public GameObject coutDown;
	public GameObject Start;
	// Use this for initialization
	public void openCountDown(){
		coutDown.SetActive(true);	
		Destroy (Start);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
