using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour {
	public Camera cam;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI truckText;
	public TextMeshProUGUI lifeText;
	public float playerState;
	public float stackHeight;
	public float mouseX;
	public float score;
	public float truck;
	public float life;
	public bool canDrop;
	public bool dead;
	public float deadTime;
	public Sprite idle;
	public Sprite bag1;
	public Sprite bag2;
	public Sprite bag3;
	public Sprite bag4;
	public Sprite bag5;
	public Sprite bag6;
	public Sprite anvilFace;
	public Sprite fishFace;
	public Sprite flowerFace;
	public AudioSource audioSource;
	public AudioClip place;
	public AudioClip land;
	public AudioClip hit;
	public AudioClip lifenoise;
	// Use this for initialization
	void Start () {
		canDrop = false;
		dead = false;
		score = 0;
		truck = 1;
		life = 3;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "SCORE: " + score;
		truckText.text = "TRUCK: " + truck;
		lifeText.text = "LIFE: " + life;
		Vector3 mouse = cam.ScreenToWorldPoint (Input.mousePosition);
		mouseX = mouse.x;
		if (mouseX < -4.68f) {
			mouseX = -4.68f;
		}
		if (mouseX > 3.75f) {
			mouseX = 3.75f;
		}

		if (stackHeight >= 20) {
			truck += 1f;
			stackHeight = 0;
		}

		if (dead == true) {
			deadTime += Time.deltaTime;
			if (deadTime >= 2f) {
				playerState = 0f;
				life -= 1f;
				deadTime = 0f;
				dead = false;
			}
		}
		if (dead == false) {
			transform.position = new Vector3 (mouseX, transform.position.y, transform.position.z);
		
			if (playerState == 0f) {
				this.GetComponent<SpriteRenderer> ().sprite = idle;
			}
			if (playerState == 1f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag1;
			}
			if (playerState == 2f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag2;
			}
			if (playerState == 3f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag3;
			}
			if (playerState == 4f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag4;
			}
			if (playerState == 5f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag5;
			}
			if (playerState == 6f) {
				this.GetComponent<SpriteRenderer> ().sprite = bag6;
				dead = true;
			}
			if (playerState < 0f) {
				playerState = 0f;
			}
		}
		if (canDrop == true) {
			if (Input.GetMouseButtonDown (0)) {
				if (playerState > 0f) {
					audioSource.clip = place;
					audioSource.Play();
					playerState -= 1f;
					score += 3;
					stackHeight += 1;
				}

			}
		}
		if (life <= -1) {
			life = 0;
			SceneManager.LoadScene ("Menu");
		}
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (dead == false) {
			if (other.gameObject.tag == "Bag") {
				playerState += 1f;
				score += 2;
				audioSource.clip = land;
				audioSource.Play ();
			}
			if (other.gameObject.tag == "Platform") {
				canDrop = true;
			}
		}

		if (other.gameObject.tag == "Anvil") {
			if (dead == false) {
				audioSource.clip = hit;
				audioSource.Play ();
				this.GetComponent<SpriteRenderer> ().sprite = anvilFace;
				dead = true;
			}

		}
		if (other.gameObject.tag == "Flower") {
			audioSource.clip = hit;
			if (dead == false) {
				audioSource.Play ();
				this.GetComponent<SpriteRenderer> ().sprite = flowerFace;
				dead = true;
			}
		}
		if (other.gameObject.tag == "Fish") {
			if (dead == false) {
				audioSource.clip = hit;
				audioSource.Play ();
				this.GetComponent<SpriteRenderer> ().sprite = fishFace;
				dead = true;
			}
		}
		if (other.gameObject.tag == "1-Up") {
			if (dead == false) {
				audioSource.clip = lifenoise;
				audioSource.Play ();
				life += 1;
			}
		}

	}
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Platform") {
			canDrop = false;
		}
	}
}

