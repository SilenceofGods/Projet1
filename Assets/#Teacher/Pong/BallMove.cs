using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//exercice 4
//Make a ball, add physival mat and impulse it


[RequireComponent(typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    [SerializeField][Range(0.5f,50)] private float forceImpulse = 5;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        restartBall();
    }

    // Update is called once per fixed frame
    void FixedUpdate()
    {
        
    }

    //why not a good idea if called from BallDeath ?
    public void restartBall()
    {
        // rb.velocity = (new Vector3(0,1*forceImpulse*-1,0));
        rb.AddForce(new Vector3(0,1*forceImpulse*-1,0),ForceMode.VelocityChange); //same
    }
}
