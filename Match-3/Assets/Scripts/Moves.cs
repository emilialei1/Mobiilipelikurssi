using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moves : MonoBehaviour
{
    public static int movesAmount = 7;
    public GameOverScript GameOverScript;
    int maxPlatform = 0;
    Text moves;
    // Start is called before the first frame update
    void Start()
    {
        moves = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        moves.text = movesAmount + " moves left";
        if(movesAmount < 1)
        {
            GameOverScript.Setup(maxPlatform); 
            if(GameOverScript.PlayAgain)
            {
                movesAmount = 7;
            }
        }
    }
}
