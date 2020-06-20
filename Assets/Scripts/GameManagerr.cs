using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerr : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    //we create a game object that we enable it when we reach the end
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    // function that identifies that the game has ended
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Restart the game:
            Invoke("Restart", restartDelay); // adds a delay 
        }
    }

    //Function that restarts the game
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
