using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour
{

    public void NextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GotoScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void IncreaseMoral() {
        PlayerState.moral++;
        Debug.Log(PlayerState.moral);
    }

    public void DecreaseMoral() {
        PlayerState.moral--;
        Debug.Log(PlayerState.moral);
    }

    public void HelpMal() {
        PlayerState.helped_mal = true;
    }

    public void HelpCass() {
        PlayerState.helped_cass = true;
    }

    public void GetBook() {
        PlayerState.has_book = true;
    }

    public void GetMoney() {
        PlayerState.has_money = true;
    }

    public void GetFood() {
        PlayerState.has_food = true;
    }

    public void IsOvertime() {
        PlayerState.overtime = true;
    }
}
