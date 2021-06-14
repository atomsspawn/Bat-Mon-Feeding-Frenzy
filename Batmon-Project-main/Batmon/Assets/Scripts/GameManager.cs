using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text life_text;
    public double life = 100;
    private string gameState;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        gameState = "Start";
    }

    void Update()
    {
        if(gameState == "Start"){
            //print("State: Start");
            // Start the game
            if (Input.GetKeyDown("space"))
            {
                gameState = "Playing";
            }
        }
        if(gameState == "Playing"){
            //print("State: Playing");
            Time.timeScale = 1;
            //Check for death
            if(life <= 0){
                gameState = "Game Over";
            }
            //Check for OP
            if(life >= 110){
                life = 110;
            }
            // Update your life
            life_text.text = "Life: " + life;
        }
        if(gameState == "Game Over"){
            //print("State: Game Over");
            Time.timeScale = 0;
            if(!gameOverCanvas.activeInHierarchy){
                Debug.Log("Game over dawg");
                gameOverCanvas.SetActive(true);
            }
            if (Input.GetKeyDown("space"))
            {
                gameOverCanvas.SetActive(false);
                gameState = "Playing";
            }
        }
    }

    public void setPoints(double pointDelta)
    {
        life += pointDelta;
    }

    public void setGameState(string newState)
    {
        gameState = newState;
    }
}
