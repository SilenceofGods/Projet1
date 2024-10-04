using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceController : MonoBehaviour {

    [SerializeField] 

    private TextMeshProUGUI scoreText,lifeText;


    void Start()
    {

       
    }

    public void UpdateScore(int value) {

        scoreText.text = "score : " + value;

    }
      public void UpdateLife(int value){

        lifeText.text = "life : " + value;
        
    }
}
