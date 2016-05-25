using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuEgg : MonoBehaviour {
	public Sprite material1;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlaySound(){
		this.GetComponent<Image>().sprite = material1;
		this.GetComponent<AudioSource>().Play();
	}
}
