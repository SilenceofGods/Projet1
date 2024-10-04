using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShot : MonoBehaviour
{


   public GameObject spawnPoint;
   public GameObject missile;

   public float shotTime;
   private float startTime;
   private float elapsedTime;




   void Start()
   {
      startTime = Time.time;
        //Instantiate(missile spawnPoint.transform.position,missile.transform.rotation); 

    }
    // Update is called once per frame
    void Update()
   {
      elapsedTime = Time.time - startTime;

      if (elapsedTime >= shotTime)
      {
         startTime = Time.time;
            Instantiate(missile, spawnPoint.transform.position, missile.transform.rotation);
            

            
        }
   }
}
