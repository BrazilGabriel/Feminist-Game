using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    //public Canvas exit;
    public Button play;
    public Button exitButton;

    void Awake() {
       // exit.enabled = false;
    }

    void start() {
        //exit = exit.GetComponent<Canvas>();
        play = play.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
    }

	public void playGame(){
        SceneManager.LoadScene("Game");
    }

    public void exitGame() {
       // exit.enabled = true;
        play.enabled = false;
        exitButton.enabled = false;
    }

    public void noPressed() {
      //  exit.enabled = false;
        play.enabled = true;
        exitButton.enabled = true;
    }

    public void yesPressed() {
        Application.Quit();
    }

    public void credits() {
       SceneManager.LoadScene("Credits");
    }
}
