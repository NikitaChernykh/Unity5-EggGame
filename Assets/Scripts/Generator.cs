using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator : MonoBehaviour {
	
	public GameObject[] availableRooms;
	
	public List<GameObject> currentRooms;
	
	private float screenHeigthinPoints;
	// Use this for initialization
	void Start () {
		float width = 5.0f * Camera.main.orthographicSize;
		screenHeigthinPoints = width * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () 
	{    
		GenerateRoomIfRequired();
	}
	
	
	void AddRoom(float farhtestRoomEndY)
	{
		//1
		int randomRoomIndex = Random.Range(0, availableRooms.Length);
		
		//2
		GameObject room = (GameObject)Instantiate(availableRooms[randomRoomIndex]);
		
		//3
		float roomHeigth = room.transform.FindChild("emptyWall").localScale.y;
		
		//4
		float roomCenter = farhtestRoomEndY + roomHeigth * 0.5f;
		
		//5
		room.transform.position = new Vector3(0, roomCenter, 0);
		
		//6
		currentRooms.Add(room);         
	}
	void GenerateRoomIfRequired()
	{
		//1
		List<GameObject> roomsToRemove = new List<GameObject>();
		
		//2
		bool addRooms = true;        
		
		//3
		float playerY = transform.position.y;
		
		//4
		float removeRoomY = playerY - screenHeigthinPoints;        
		
		//5
		float addRoomY = playerY + screenHeigthinPoints;
		
		//6
		float farthestRoomEndY = 0;

		foreach(var room in currentRooms)
		{
			//7
			float roomHeigth = room.transform.FindChild("emptyWall").localScale.y;
			float roomStartY = room.transform.position.y + (roomHeigth * 0.5f);    
			float roomEndY = roomStartY + roomHeigth;                            
			
			//8
			if (roomStartY > addRoomY)
				addRooms = false;
			
			//9
			if (roomEndY < removeRoomY)
				roomsToRemove.Add(room);
			
			//10
			farthestRoomEndY = Mathf.Max(farthestRoomEndY, roomEndY);
		}
		
		//11
		foreach(var room in roomsToRemove)
		{
			currentRooms.Remove(room);
			Destroy(room);            
		}
		
		//12
		if (addRooms)
			AddRoom(farthestRoomEndY);
	}
}

