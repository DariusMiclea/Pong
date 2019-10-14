using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeftWall : MonoBehaviour {
    public int score;
    public Text player2Score;
    public Ball ball;
    private Ball b;
    public GameManager gameManager;

	
	void Update () {
        player2Score.text = "Score: " + score.ToString();
        if(score >= 7)
        {
            SceneManager.LoadScene("winScene2");
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
