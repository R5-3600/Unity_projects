using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {
	private Rigidbody2D rb;
	public Sprite broken;
	public bool fade;
	public float deadTime;
	private Vector2 moveAngle;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		moveAngle = new Vector2 (Random.Range(-800f, -250f), Random.Range(250f, 600f));
		rb.AddForce (moveAngle, ForceMode2D.Force);
		deadTime = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (fade == true) {
			if (deadTime <= 0) {
				Destroy (this.gameObject);
			} else {
				deadTime -= Time.deltaTime;
			}
		}
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Destroy(this.gameObject);
		}
		if (other.gameObject.tag == "Ground") {
			Destroy (this.GetComponent<Rigidbody2D> ());
			this.GetComponent<SpriteRenderer> ().sprite = broken;
			fade = true;
		}
		}
}
