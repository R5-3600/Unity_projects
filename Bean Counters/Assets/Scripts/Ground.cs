using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public AudioSource audioSource;
	public AudioClip bagsplat;
	public AudioClip anvilsplat;
	public AudioClip fishsplat;
	public AudioClip flowersplat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
		void OnTriggerEnter2D (Collider2D other)
		{
			if (other.gameObject.tag == "Bag") {
				audioSource.clip = bagsplat;
				audioSource.Play ();
			}
			if (other.gameObject.tag == "Anvil") {
				audioSource.clip = anvilsplat;
				audioSource.Play ();
			}
			if (other.gameObject.tag == "Flower") {
				audioSource.clip = flowersplat;
				audioSource.Play ();
			}
			if (other.gameObject.tag == "Fish") {
				audioSource.clip = fishsplat;
				audioSource.Play ();
			}
	}
}
