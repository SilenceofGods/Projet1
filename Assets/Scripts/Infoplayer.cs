using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infoplayer : MonoBehaviour
{
    public int score = 0;

    [SerializeField]

    private InterfaceController gui;


    void Start() {

    }


    public void AddScore(int value){ 


        score += value;
        Debug.Log("Score actuel du player :" + score);

        gui.UpdateScore(score);
       
    }

}