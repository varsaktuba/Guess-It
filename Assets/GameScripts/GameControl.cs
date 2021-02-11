using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI, gamewinUI, startUI;
    [HideInInspector] public Player player;
    [HideInInspector] public SliderControl slider;

    void Start()
    {
        //PlayerPrefs.SetInt("CURRENTSCENE", SceneManager.GetActiveScene().buildIndex);
        //PlayerPrefs.Save();

    }
   

    public void EndGame()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        player.GetComponent<Animator>().SetBool("isVictory", false);

    }



    public void StartGame()
    {

        SceneManager.LoadScene("1");
    }
    

    public void WinGame()
    {
        player.GetComponent<Animator>().SetBool("isVictory", true);
        gamewinUI.SetActive(true);
        PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex-1);
        FindObjectOfType<SliderControl>().GameOver();
        Time.timeScale = 0f;

    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;

    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void QuitGame()
    {
        Application.Quit();

    }
    public void Return()
    {
        SceneManager.LoadScene("LockScreen");
    }
}

