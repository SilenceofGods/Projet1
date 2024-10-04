using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        
        float verticalDirection = Input.GetAxis("Vertical");
        

        Vector3 position = transform.position;
        float nextXPos = transform.position.x + (horizontalDirection * Time.deltaTime * speed);

        position.x = nextXPos;
        float nextYPos = transform.position.y + (verticalDirection * Time.deltaTime * speed);


        position.y = nextYPos;
        rb.MovePosition(position);//j'assigne la variable position que nous avons calculer dans transform (je déplace l'objet)

        Fire();
    }

    void Fire()
    {

    }

}
