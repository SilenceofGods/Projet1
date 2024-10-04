using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infoplayer : MonoBehaviour
{
    public int score = 0;
    //TODO créer une variable de type int pour la vie
    [SerializeField] private InterfaceController gui;


    void Start() {

    }


    public void AddScore(int value){ 


        score += value;
        Debug.Log("Score actuel du player :" + score);

        gui.UpdateScore(score);
       
    }
    
    
    //TODO créer une méthode pour enlever de la vie
    //TODO ++ mettre à jour l'interface !!

}