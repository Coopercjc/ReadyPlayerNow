using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Text secondsSurvivedUI;
    //private bool pass = false;

    bool gameOver;

    // Update is called once per frame
    void Start(){
        FindObjectOfType<PlayerController>().OnPlayerDeath += OnGameOver;
    }
    
    void Update()
    {
        if(gameOver){
            if(Input.GetKeyDown(KeyCode.Space)){
                if (Mathf.RoundToInt(Time.timeSinceLevelLoad) >= 30) {
                    secondsKeeper.Show1 = true;
                    secondsKeeper.Music = true;
                    //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
                    SceneManager.LoadScene(2);
                }
                else {
                    //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
                    secondsKeeper.Music = true;
                    SceneManager.LoadScene(0);
                }
            }
        }
    }

    void OnGameOver(){
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;

    }
}
