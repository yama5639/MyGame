using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    private int coinCount;
    private void Start()
    {
        coinCount = 0;
        Application.targetFrameRate = 60;
        coinCount = 0;
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public Text textComponent;
    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        textComponent.text = "CoinCount : " + coinCount;
    }
}
