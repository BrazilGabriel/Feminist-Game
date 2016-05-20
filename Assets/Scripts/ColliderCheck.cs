using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderCheck : MonoBehaviour {
	public static int score;
    public static bool dead;

    public void Awake()
    {
    }
	void Start () {		
		score = 0;
        dead = false;
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
			SaveScore();
            dead = true;
            Time.timeScale = 0;

            //	Application.LoadLevel(Application.loadedLevel);
        }
	}
	
	public void SaveScore(){
		PlayerPrefs.SetInt("currentScore", score);
		if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore")){
			PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
		}
	}
}
		