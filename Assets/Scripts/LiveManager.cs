using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LiveManager : MonoBehaviour {
	private  static int lifeCounter;
	private  int lifeStarting = 3;

	public Egg player;
	public Text liveTxt;

	// Use this for initialization
	void Start () {

		lifeCounter = lifeStarting;
		player = FindObjectOfType<Egg> ();
	}
	
	// Update is called once per frame
	void Update () {
		liveTxt.text = "" + Mathf.Round (lifeCounter);
		if (lifeCounter == 0) {
			Application.LoadLevel(2);
		}
	}
	public static void HurtPlayer(int damage){
		lifeCounter -= damage;

	}
}
