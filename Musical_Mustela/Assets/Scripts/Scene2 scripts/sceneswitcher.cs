using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneswitcher : MonoBehaviour
{
    public void Previous()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("game has ended je ziet het niet in unity please zeg dit tegen jayden macdonalds voordat ik dood ga");
    }





}
