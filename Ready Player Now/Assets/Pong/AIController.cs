using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {
    
    public float aiSpeed = 5.0f;
    public float boundY = 2.25f;
    private float accel = 5.0f;
    private Rigidbody2D rb2d;
    public BallControl ball;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        var pos = transform.position;
        if ( vel.y < aiSpeed && (pos.y + .15) < ball.transform.position.y && ball.veloc.x < 0) {
            vel.y = aiSpeed - accel * Time.deltaTime;
        } else if ( vel.y > -aiSpeed && (pos.y - .15) > ball.transform.position.y && ball.veloc.x < 0) {
            vel.y = -aiSpeed + accel * Time.deltaTime;
        } else {//if (pos.y == ball.transform.position.y) {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        //var pos = transform.position;
        if (pos.y > boundY) {
            pos.y = boundY;
        } else if (pos.y < -boundY) {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}

/*
void Update()
{
if ((Input.GetKey("left")) && (Speed < MaxSpeed)) 
    Speed = Speed - Acceleration * Time.deltaTime;
else if ((Input.GetKey("right")) && (Speed > -MaxSpeed)) 
    Speed = Speed + Acceleration * Time.deltaTime;
else
{
    if (Speed > Deceleration * Time.deltaTime) 
            Speed = Speed - Deceleration * Time.deltaTime;
    else if (Speed < -Deceleration * Time.deltaTime) 
            Speed = Speed + Deceleration * Time.deltaTime;
    else
        Speed = 0;
}
position.x = transform.position.x + Speed * Time.deltaTime;
transform.position = position;
}*/