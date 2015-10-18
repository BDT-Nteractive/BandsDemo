using UnityEngine;
using System.Collections;

public class NewGameManager : MonoBehaviour {
	
	public GameObject playerPrefab;
	
	private TimeManager timeManager;
	private GameObject player;
	private GameObject floor;
	private Spawner spawner;
	
	void Awake(){
		floor = GameObject.Find ("Foreground");
		spawner = GameObject.Find ("Spawner").GetComponent<Spawner> ();
		timeManager = GetComponent<TimeManager> ();
	}
	
	// Use this for initialization
	void Start () {
		
		var floorHeight = floor.transform.localScale.y;
		
		var pos = floor.transform.position;
		pos.x = 0;
		pos.y = -(1.4f);
		floor.transform.position = pos;
		
		spawner.active = false;
		
		ResetGame ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Q) == true) {

			Application.Quit();
		}
		if (Input.GetKeyDown (KeyCode.R) == true) {
			Application.LoadLevel(Application.loadedLevelName);
		}
		
	}
	
	void OnPlayerKilled(){
		spawner.active = false;
		

		
		player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		timeManager.ManipulateTime (0, 5.5f);
	}
	
	void ResetGame(){
		spawner.active = true;
		

		
	}
}
