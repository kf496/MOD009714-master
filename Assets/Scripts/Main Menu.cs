using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next scene in queue
    }
public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit(); //Closes app
        EditorApplication.isPlaying = false; //Stops running in Unity Editor
    }
}
