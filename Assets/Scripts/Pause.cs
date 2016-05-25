using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool paused ;
	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(paused){
			Time.timeScale = 0;
		}else if (!paused){
			Time.timeScale = 1;
		}
	}

	public void GamePause(){
		paused = true;
		pauseMenu.SetActive(true);
	}
	public void Resume(){
		paused = false;
		pauseMenu.SetActive(false);
	}
	public void Menu(){
		Application.LoadLevel(0);
	}

}
