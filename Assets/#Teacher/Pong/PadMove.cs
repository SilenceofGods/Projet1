//#define exercice1
#define exercice7

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))] //no RB here !! Or no bounce will occur with bounce mat's ball
public class PadMove : MonoBehaviour
{
    [SerializeField] private KeyCode leftControl = KeyCode.LeftArrow;   
    [SerializeField] private KeyCode rightControl = KeyCode.RightArrow;
    [SerializeField] [Range(5,50)]private float xSpeed = 1f;
    
#if exercice7

     [SerializeField] private int score = 0;

#endif
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //exercice 3
    //Physical keyboard in InputManager: A is Q for example
    //exercice 3bis
    //inverse left/right with up/down and change the world design for horizontal mode playing

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftControl))
        {
            transform.Translate(new Vector3(xSpeed * Time.deltaTime * -1,0,0));
        }
        else if (Input.GetKey(rightControl))
        {
            transform.Translate(new Vector3(xSpeed * Time.deltaTime,0,0));
        }
        
#if exercice1

        else if (Input.GetKeyDown(KeyCode.RightArrow))   exo1: ///Input.GetKeyDown(rightControl)  why not ? // exo 2: why KeyCode.RightArrow is not scalable ? => padPRefab
        {
            transform.Translate(new Vector3(xSpeed * Time.deltaTime,0,0));
        }

#endif
    }
    
#if exercice7

    //exercice 7: why it's a bad idea to put the logic here ? And why the program design is bad ?
    public int addScore()
    {
        score++;
        return score;
    }

#endif
}
