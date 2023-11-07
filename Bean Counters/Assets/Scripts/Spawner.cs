using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	List<GameObject> hazardList = new List<GameObject> ();
	public float truck;
	public float startSpawnTime;
	private float spawnTime;
	public float spawnTime2;
	public int startSpawnTime2;
	public int startHazardTime;
	public float hazardTime;
	public int startLifeTime;
	public float lifeTime;
	public GameObject bag;
	public GameObject anvil;
	public GameObject flower;
	public GameObject fish;
	public GameObject life;
	public int rangetop;
	// Use this for initialization
	void Start () {
		startSpawnTime2 = Random.Range (1, 7);
		startHazardTime = Random.Range (1, 6);
		startLifeTime = Random.Range (20, 25);
		spawnTime2 = startSpawnTime2;
		hazardTime = startHazardTime;
		lifeTime = startLifeTime;
		hazardList.Add (anvil);
		hazardList.Add (fish);
		hazardList.Add (flower);
		rangetop = 1;
	}

	// Update is called once per frame
	void Update () {
		truck = GetComponent<Player>().truck;
		if (spawnTime <= 0) {
			Instantiate (bag, new Vector3 (6f, 1f, 0f), Quaternion.identity);
			spawnTime = startSpawnTime;
		} else {
			spawnTime -= Time.deltaTime;
		}
		if (spawnTime2 <= 0) {
			Instantiate (bag, new Vector3 (6f, 1f, 0f), Quaternion.identity);
			startSpawnTime2 = Random.Range (1, 7);
			spawnTime2 = startSpawnTime2;
		} else {
			spawnTime2 -= Time.deltaTime;
		}
		if (truck >= 2) {
			if (hazardTime <= 0) {
				Instantiate (hazardList[Random.Range(0,rangetop)], new Vector3 (6f, 1f, 0f), Quaternion.identity);
				startHazardTime = Random.Range (1, 6);
				hazardTime = startHazardTime;
			} else {
				hazardTime -= Time.deltaTime;
			}
			if (truck == 2) {
				rangetop = 1;
			}
			if (truck == 3) {
				rangetop = 2;
			}
			if (truck == 4) {
				rangetop = 3;
			}
				
		
		}
		if (truck >= 3) {
			if (lifeTime <= 0) {
				Instantiate (life, new Vector3 (6f, 1f, 0f), Quaternion.identity);
				startLifeTime = Random.Range (20, 25);
				lifeTime = startLifeTime;
			} else {
				lifeTime -= Time.deltaTime;
			}

		}
	}
}
