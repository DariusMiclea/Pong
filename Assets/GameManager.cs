using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Ball ball;
    public Player1 player1;
    public Player2 player2;
    private Ball b;
    private Player2 pl2;
    
    
	// Use this for initialization
	void Start () {
        b = Instantiate(ball);
        Instantiate(player1);
        pl2 = Instantiate(player2);

        if(SceneManager.GetActiveScene().name == "pongScene")
        {
            pl2.tag = "Player2";
        }

	}

    private void FixedUpdate()
    {
        if(SceneManager.GetActiveScene().name == "1Player" && b != null)
        {
            if(b.transform.position.y > pl2.transform.position.y && b.transform.position.x > 0)
            {
                pl2.Computer("up");
            }
            if(b.transform.position.y < pl2.transform.position.y && b.transform.position.x > 0)
            {
                pl2.Computer("down");
            }
        }
    }

    public void NewBall()
    {
        b = Instantiate(ball);
    }


}
