using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverUI;
    public static bool PlayAgain = false;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }

    public void PlayButton()
    {
        gameOverUI.SetActive(false);
        PlayAgain = true;
        SceneManager.LoadScene("SampleScene");
        Score.scoreValue = 0;
    }
    public void ExitButton()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene("MainMenu");
        Score.scoreValue = 0;
        Moves.movesAmount = 7;
    }
}
