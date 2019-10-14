using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed;
    float x, y;
    private float timeLeft;
    public Rigidbody2D rb;
    private Vector2 direction;
    // Use this for initialization
	void Start () {
        
        direction = Random.insideUnitCircle.normalized;
        rb.AddForce(direction * speed);

	}
	
    
}
