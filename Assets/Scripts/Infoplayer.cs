using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Infoplayer : MonoBehaviour
{
    public int score = 0;

    private int life = 4;
    //TODO créer une variable de type int pour la vie
    [SerializeField] private InterfaceController gui;


    void Start()
    {

    }


    public void AddScore(int value)
    {


        score += value;
        Debug.Log("Score actuel du player :" + score);

        gui.UpdateScore(score);
    }

    public void Damage()
    {
        life = life -1;       

        if (life < 1)
        {
            Destroy(this.gameObject);
        }
    }



    //TODO créer une méthode pour enlever de la vie
    //TODO ++ mettre à jour l'interface !!

}