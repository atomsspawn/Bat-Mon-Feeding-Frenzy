using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text BatFacts;
    

    public void Setup()
    {
        gameObject.SetActive(true);


    }

    private void Start()
    {

        int i = Random.Range(0, 7);
        BatFacts.text = FastFacts[i];
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");

    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Array containing various bat facts for displaying at the end of a game or level.
    public string[] FastFacts = new string[] {"A group of bats in a cave is called a colony.","Most bats are very intelligent.",
        "Nake bats, just as the name suggest, have no fur.","Bats are the only mammals with true wings that are capable of flight.",
        "The smallest bats, Bumblebee bats, weigh between 2 to 3 grams.","The Spix's disk-winged bat has suction cups on its thumbs & hind feet.",
        "A group of bats is sometiimes called a cauldron.","A group of bats in flight is called a cloud."};

    

}


