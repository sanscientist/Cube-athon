using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    // Update is called once per frame
    //public allows function to be noticed

    //Display Level Complete Text
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        //Debug.Log("LEVEL WON!");
        //true - active, false - inactive
        CompleteLevelUI.SetActive(true);

    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart Game 
            //Delay the function
            Invoke("Restart", restartDelay);
            //Restart();
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
