using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameManager gameManager;
    public int playerHP = 1;
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        //if (playerHP <= 0)
        //{
        //    SceneManager.LoadScene("GameoverScene");
        //}

    }
    private int enemyCount;
    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;

        enemyCount = 0;

    }

    private void Update()
    {
        if (enemyCount == 5)
        {
            gameManager.ChangeScene("ClearScene");
        }
    }

    public Text textComponent;
    public void AddEnemyCount()
    {
        enemyCount = enemyCount + 1;
        textComponent.text = "Œ‚”j : " + enemyCount;
    }
}
