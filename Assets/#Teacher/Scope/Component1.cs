using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component1 : MonoBehaviour
{
    [SerializeField] private int life;

    public void changelife(int value)
    {
        Debug.Log("Appel de la méthode ChangeLife effectué");
        life = life + value;
    }

   
}
