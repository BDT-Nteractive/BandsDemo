using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 20.0f;
	public bool active = true;
	private int click = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (EnemyGenerator ());
	}
	void Update(){
//		if (Time.time%5 == 0 || Time.time >= 15)
//			delay *= .5f;
//		if (Time.time >= 55)
//			delay = 1.5f;
	}
	IEnumerator EnemyGenerator(){

		yield return new WaitForSeconds (delay);

		if (active) {
			var newTransform = transform;

			Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);
		}

		StartCoroutine (EnemyGenerator ());

	}

}
