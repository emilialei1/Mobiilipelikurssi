﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }

    public void ExitButton()
    {

    }
}
