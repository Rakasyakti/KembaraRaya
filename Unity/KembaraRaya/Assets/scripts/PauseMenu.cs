using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false; 
  public GameObject pauseMenuUI;
  public GameObject engine;
  public GameObject sea;

    void Start(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        GameIsPaused = false;
    }

    void Update(){
        if (Input.GetKeyDown("escape")){
            if (GameIsPaused) {Resume();} 
            else {Pause();}
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        GameIsPaused = false;
        engine.GetComponent<AudioSource>().UnPause();
        sea.GetComponent<AudioSource>().UnPause();
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        GameIsPaused = true;
        engine.GetComponent<AudioSource>().Pause();
        sea.GetComponent<AudioSource>().Pause();
    }

    public void Menu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit(){
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void Restart(){
        SceneManager.LoadScene("Terrain");
    }
}
