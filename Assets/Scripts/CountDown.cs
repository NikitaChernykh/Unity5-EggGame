using UnityEngine;
using System.Collections;
using UnityEngine.UI;
		
public class CountDown : MonoBehaviour {
	public int countDown;
	public Text countTxt;
	public int countMax ;
	private GameObject coutDown;


	void Start (){
		StartCoroutine (GetReady());
	}
	

	IEnumerator GetReady () {
		for (countDown = countMax; countDown > 0; countDown--) {
			countTxt.text = countDown.ToString ();
			yield return new WaitForSeconds (1);//to desplay go message
			if (countDown == 1) {
				countTxt.text = countDown.ToString("GO");
				yield return new WaitForSeconds (1);
				coutDown = GameObject.Find ("CountDown");
				Destroy (coutDown);
			}
		}
	}
}
