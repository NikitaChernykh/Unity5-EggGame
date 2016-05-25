using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highScore;
	public Text seedScore;
	private static int score;
	public float scoreCount;
	public float highScoreCount;


	public float pointsPerSec;

	public bool scoreIncresing;

	// Use this for initialization
	void Start () {
		scoreCount = 0;
		score = 0;
	}
	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}
	// Update is called once per frame
	void Update () {
		seedScore.text = "" + Mathf.Round (score);
		if (scoreIncresing) {

			scoreCount += pointsPerSec * Time.deltaTime;
		}


		if (scoreCount > highScoreCount) {

			highScoreCount = scoreCount;
		}

		scoreText.text = ""+Mathf.Round(scoreCount);
		//highScore.text = "High Score: " + Mathf.Round(highScoreCount);

	}
}
