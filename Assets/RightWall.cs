using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RightWall : MonoBehaviour {
    public int score;
    public Text player1Score;
    public Ball ball;
    public GameManager gameManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player1Score.text = "Score: " + score.ToString();
        if (score >= 7)
        {
            SceneManager.LoadScene("winScene");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score++;
            Destroy(collision.gameObject);
            gameManager.NewBall();
        }
        
    }
}
