using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component2 : MonoBehaviour
{
    [SerializeField] private Component1 comp1;
    
    // Start is called before the first frame update
    void Start()
    {
        //comp1.life = 15; // interdit !!
        comp1.changelife(-4);
    }

}
