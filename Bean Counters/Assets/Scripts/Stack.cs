using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour {
	public float stackHeight;
	public GameObject Bag1;
	public GameObject Bag2;
	public GameObject Bag3;
	public GameObject Bag4;
	public GameObject Bag5;
	public GameObject Bag6;
	public GameObject Bag7;
	public GameObject Bag8;
	public GameObject Bag9;
	public GameObject Bag10;
	public GameObject Bag11;
	public GameObject Bag12;
	public GameObject Bag13;
	public GameObject Bag14;
	public GameObject Bag15;
	public GameObject Bag16;
	public GameObject Bag17;
	public GameObject Bag18;
	public GameObject Bag19;
	public GameObject Bag20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		stackHeight = GetComponent<Player>().stackHeight;

		if (stackHeight == 0.0f) {
			Bag1.SetActive (false);
			Bag2.SetActive (false);
			Bag3.SetActive (false);
			Bag4.SetActive (false);
			Bag5.SetActive (false);
			Bag6.SetActive (false);
			Bag7.SetActive (false);
			Bag8.SetActive (false);
			Bag9.SetActive (false);
			Bag10.SetActive (false);
			Bag11.SetActive (false);
			Bag12.SetActive (false);
			Bag13.SetActive (false);
			Bag14.SetActive (false);
			Bag15.SetActive (false);
			Bag16.SetActive (false);
			Bag17.SetActive (false);
			Bag18.SetActive (false);
			Bag19.SetActive (false);
			Bag20.SetActive (false);
		}

		if (stackHeight == 1.0f) {
			
			Bag1.SetActive (true);

		}

		if (stackHeight == 2.0f) {
			
			Bag2.SetActive (true);

		}

		if (stackHeight == 3.0f) {
			
			Bag3.SetActive (true);

		}

		if (stackHeight == 4.0f) {
			
			Bag4.SetActive (true);
		}

		if (stackHeight == 5.0f) {

			Bag5.SetActive (true);

		}

		if (stackHeight == 6.0f) {
			
			Bag6.SetActive (true);

		}

		if (stackHeight == 7.0f) {
			
			Bag7.SetActive (true);

		}

		if (stackHeight == 8.0f) {
			
			Bag8.SetActive (true);

		}

		if (stackHeight == 9.0f) {
			
			Bag9.SetActive (true);

		}
	
		if (stackHeight == 10.0f) {
			
			Bag10.SetActive (true);

		}

		if (stackHeight == 11.0f) {
			
			Bag11.SetActive (true);

		}

		if (stackHeight == 12.0f) {

			Bag12.SetActive (true);

		}

		if (stackHeight == 13.0f) {

			Bag13.SetActive (true);

		}

		if (stackHeight == 14.0f) {

			Bag14.SetActive (true);

		}

		if (stackHeight == 15.0f) {

			Bag15.SetActive (true);

		}

		if (stackHeight == 16.0f) {

			Bag16.SetActive (true);

		}

		if (stackHeight == 17.0f) {

			Bag17.SetActive (true);

		}

		if (stackHeight == 18.0f) {

			Bag18.SetActive (true);

		}

		if (stackHeight == 19.0f) {

			Bag19.SetActive (true);

		}

		if (stackHeight == 20.0f) {

			Bag20.SetActive (true);

		}

	}
}
