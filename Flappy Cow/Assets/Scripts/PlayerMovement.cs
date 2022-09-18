using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public TextMeshProUGUI scoreText;
    public float jumpAmount = 8f;

    private int score;



    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpAmount);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ScoreTrigger"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
