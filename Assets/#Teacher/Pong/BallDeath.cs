using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//exercice 5
//Detect collision with "Wall" tag GO   and //ballMove.restartBall();   //Why not ? => more and more velocity !!
//exercice 6
//Determine wich player'pad has loose ?

public class BallDeath : MonoBehaviour
{
    [SerializeField] private Transform ballStartTransform;
    //[SerializeField] private BallMove ballMove;
    [SerializeField] private GameManager gameManager; //exercice 8

    //exercice 6
    [SerializeField] private GameObject pad1LooseWall;
    [SerializeField] private GameObject pad2LooseWall;
   
    void Awake()
    {
        transform.position = ballStartTransform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("ball entre en collision avec "+other.gameObject.name);
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("ball entre en collision avec un Wall");
            transform.position = ballStartTransform.position;
            //ballMove.restartBall();   //Why not ? => more and more velocity !!
            
            //exercice 6
            //How to determine wich player's pad has loose ?
            if (pad1LooseWall.name == other.gameObject.name)
            {
                Debug.Log("pad 1 loose");
                //GameObject.Find("Pad2").GetComponent<PadMove>().addScore(); //exercice 7: here is the bad idea !!
                gameManager.updateScore(false);
            }
            else if (pad2LooseWall.name == other.gameObject.name)
            {
                Debug.Log("pad 2 loose");
               // GameObject.Find("Pad1").GetComponent<PadMove>().addScore();//exercice 7
                gameManager.updateScore(true);
            }
        }
    }
}
