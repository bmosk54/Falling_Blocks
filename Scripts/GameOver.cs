using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject gameOverScreen;
    public Text timeSurivedTag;
    public Text secondsSurvived;
    bool gameOver;

    void Start() {
        FindObjectOfType<PlayerMovement>().OnPlayerDeath += OnGameOver;
    }

    void Update() {
        if (gameOver) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(0);
            }
        }
    }

    void OnGameOver() {
        gameOverScreen.SetActive(true);
        timeSurivedTag.gameObject.SetActive(false);
        //secondsSurvived.text = Time.timeSinceLevelLoad.ToString();
        secondsSurvived.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }
}
