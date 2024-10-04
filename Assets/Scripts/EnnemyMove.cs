using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour { 

    public float speed = 5f;
    Transform myTransform;
    
    void Start(){ 
    
      myTransform = GetComponent<Transform>();
      speed = Random.Range(speed -1f, speed + 1f);
    }

    
    void Update(){ 
    
     myTransform.Translate(Vector3.down*Time.deltaTime *speed);

    }
}
