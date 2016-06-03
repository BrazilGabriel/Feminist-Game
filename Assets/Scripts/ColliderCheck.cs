using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderCheck : MonoBehaviour {
	public static int score;
    public static bool dead;

    public void Awake()
    {
		score = 0;
        dead = false;
    }
	void Start () {		
	}

	void Update () {
        if (!dead)
        {
		score += (int) Time.deltaTime;
        }
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag.Equals ("Barreira")) {
            //StartCoroutine (DelayedLoad ());
            dead = true;
			SaveScore();
            Time.timeScale = 0;

            //	Application.LoadLevel(Application.loadedLevel);
        }
	}
	
	public void SaveScore(){
		score = Controller.score;
		PlayerPrefs.SetInt("currentScore", score);
		if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore")){
			PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
		}
	}
}
		