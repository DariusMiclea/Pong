using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if(this.tag == "Player2")
        {
            Player();
        }
        

    }
    private void Player()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed, 0);
        }
        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -3.5f, 3.5f);
        transform.position = position;
    }

    public void Computer(string move)
    {
        if(move == "up")
        {
            transform.Translate(0, speed, 0);
        }
        if(move == "down")
        {
            transform.Translate(0, -speed, 0);
        }


        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -3.5f, 3.5f);
        transform.position = position;
    }
}
