using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{    
    public Player player;
    public AudioCrash audioCrash;
    public Text gameOverCountdown;
    public float countTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (player.isDead)
        {
            audioCrash.Crash();
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }

        gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");

        if (countTimer < 0)
        {
            RestartGame();
        }
    }
   

    public void GameOver()
    {
        Time.timeScale = 0;
    }


    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0);
    }
}