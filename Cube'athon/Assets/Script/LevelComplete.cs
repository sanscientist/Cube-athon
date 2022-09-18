using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //used to change the scene of the game
public class LevelComplete : MonoBehaviour
{
 
    //trigger script for the next level
    public void LoadNextLevel()
    {
        //Debug.Log("Next Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
