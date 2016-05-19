using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderCheck : MonoBehaviour {
	public int score;

	void Start () {		
		score = 0;
	}

	void Update () {
		score += (int) Time.deltaTime;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag.Equals ("Barreira")) {
			//StartCoroutine (DelayedLoad ());
			SaveScore();
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	
	public void SaveScore(){
		PlayerPrefs.SetInt("currentScore", score);
		if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore")){
			PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
		}
	}
}
		