using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    public float speed;


    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.down);
        //Debug.Log("l'ennemy tire");

      
    } 
}