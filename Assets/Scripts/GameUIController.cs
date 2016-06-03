using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject PauseButton;
    public GameObject GameOverUI;
    public GameObject Hud;

    public Text gameScore;
    public Text gameHighScore;


    public Text scoreText;
    public Text highScoreText;

    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
        GameOverUI.SetActive(false);
    }

    void Update()
    {
        gameScore.text = "Score: " + Controller.score.ToString() + "M";
        gameHighScore.text = "HighScore: " + PlayerPrefs.GetInt("highScore").ToString() + "M";
    }


    public void Pause()
    {

        paused = !paused;

        if (paused)
        {
            GameOverUI.SetActive(false);
            PauseUI.SetActive(true);
            PauseButton.SetActive(false);
            Time.timeScale = 0;
        }

        if (!paused)
        {

            PauseUI.SetActive(false);
            PauseButton.SetActive(true);
            Time.timeScale = 1;
        }

    }

    public void Restart()
    {
        Time.timeScale = 1;
        GameOverUI.SetActive(false);
        SceneManager.LoadScene("RealGame");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }



    void OnGUI()
    {
        if (!paused)
        {
            //  DisplayCoinsCount();
        }

        if (ColliderCheck.dead == true)
        {
            GameOverUI.SetActive(true);
            Hud.SetActive(false);
            showScore();
        }
    }

    public void showScore()
    {
        //Svar score = 0;
		scoreText.text = "Score: "+ Controller.score.ToString() + "M";
       // score = PlayerPrefs.GetInt("highScore");
		highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("highScore").ToString() + "M";
    }

}