using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//Script inutile
public class Collisions : MonoBehaviour 

{
    public int scoreDestruction = 10;


    [SerializeField] private GameObject player;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("player");

        Debug.Log(player);

    }
    void OnCollisionEnter2D(Collision2D other)
    {

        Debug.Log("Ennemi entre en collision avec " + other.gameObject.name);


        if (other.gameObject.tag == "Missile")
        {
            Debug.Log("************** Ennemi entre en collision avec un missile"); 

            Destroy(this.gameObject);

            Destroy(other.gameObject);

            player.GetComponent<Infoplayer>().AddScore(scoreDestruction);


        




       }

    }
}
