using UnityEngine;
using System.Collections;

public class SwipeHandler : MonoBehaviour {
	public float minMovement = 40.0f;
	public bool sendUpMessage = true;
	public bool sendDownMessage = true;
	public bool sendLeftMessage = true;
	public bool sendRightMessage = true;
	public GameObject MessageTarget = null;


	private Vector2 StartPos;
	private int SwipeID = -1;
	
	void Update ()
	{
		if (MessageTarget == null)
			MessageTarget = gameObject;
		foreach (var T in Input.touches)
		{
			var P = T.position;
			if (T.phase == TouchPhase.Began && SwipeID == -1)
			{
				SwipeID = T.fingerId;
				StartPos = P;
			}
			else if (T.fingerId == SwipeID)
			{
				var delta = P - StartPos;
				if (T.phase == TouchPhase.Moved && delta.magnitude > minMovement)
				{
					SwipeID = -1;
					if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
					{
						if (sendRightMessage && delta.x > 0)
							MessageTarget.SendMessage("OnSwipeRight", SendMessageOptions.DontRequireReceiver);
						else if (sendLeftMessage && delta.x < 0)
							MessageTarget.SendMessage("OnSwipeLeft", SendMessageOptions.DontRequireReceiver);
					}
					//else
					//{
					//	if (sendUpMessage && delta.y > 0)
					//		MessageTarget.SendMessage("OnSwipeUp", SendMessageOptions.DontRequireReceiver);
					//	else if (sendDownMessage && delta.y < 0)
					//		MessageTarget.SendMessage("OnSwipeDown", SendMessageOptions.DontRequireReceiver);
					//}
				}
				else if (T.phase == TouchPhase.Canceled || T.phase == TouchPhase.Ended)
				{
					SwipeID = -1;
					MessageTarget.SendMessage("OnTap", SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}    


	

}
