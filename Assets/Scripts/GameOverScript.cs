using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public bool gameOver;

    public void showGameOver()
    {
        gameObject.SetActive(true);
    }
}