using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(other.transform.root.gameObject);
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            Destroy(collision.gameObject);
            //Debug.Log("collision");
        }
    } 
}
