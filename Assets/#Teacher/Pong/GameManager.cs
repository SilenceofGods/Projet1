using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//exercice 8
//New class for Game Mangement and a first better programm design than in exercice 7
// But it will be even better if the addScore method is not in PadMove component but in a new one called PadScore or in this GameManager directly !!

//exercice 9
//Add music (here in this class ?) and loose sound (here in this class ?) and ball bouncing sound (in a new BallSound script)

//exercice 10
//Separate IHM from the logic Code (new class IHM)

//exercice more
//Add a limit in score (10 for example) and add a restart game Button if the limit is reached (pause game) => need to restart ball and Pads too !! (what about programm design ??)

public class GameManager : MonoBehaviour
{
    [SerializeField] private PadMove pad1;
    [SerializeField] private PadMove pad2;
    
    [SerializeField] private TextMeshProUGUI pad1Score;
    [SerializeField] private TextMeshProUGUI pad2Score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updateScore(bool isPad1)
    {
        if (isPad1)
        {
            pad1Score.text = pad1.addScore().ToString();
        }
        else
        {
            pad2Score.text = pad2.addScore().ToString();
        }
    }
}
