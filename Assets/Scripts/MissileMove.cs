using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    public int scoreDestruction;
    [SerializeField] private GameObject player;
    public float speed = 12f;
    [SerializeField] Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        scoreDestruction = 10;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + (Vector3.up * speed * Time.deltaTime));
        Destroy(this.gameObject, 1f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(" détection réeussi "+ collision.gameObject.name);
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            Debug.Log("entre bien en collision avec ennemie ");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            player.GetComponent<Infoplayer>().AddScore(scoreDestruction);
        }
        //TODO compléter ici le code pour que un missile puisse détecter une collision avec le "player"
        //TODO si détection détruire le missile
        //TODO enlever de la vie au player en utilisant la méthode qui sera crée ds Infoplayer (script)

    }
}











