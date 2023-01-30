using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GotoScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Game has been exited");
    }
}
