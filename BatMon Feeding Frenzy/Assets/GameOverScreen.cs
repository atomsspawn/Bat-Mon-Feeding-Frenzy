using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text batFacts;

    public void Setup()
    {
        gameObject.SetActive(true);
        batFacts.text = ("A group of bats in flight is called a cloud.");

    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");

    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
