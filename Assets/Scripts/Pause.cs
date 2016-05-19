using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	bool controlPause =true;
	Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			pause();
		}
	}
	public void pause(){
		if (controlPause) {
			canvas.enabled = true;
			Time.timeScale = 0;
			controlPause = false;
		} else {
			canvas.enabled = false;
			Time.timeScale = 1;
			controlPause = true;
		}

	}	
	public void RestartLevel(){
		Application.LoadLevel(Application.loadedLevel);		
		controlPause = false;		
		Time.timeScale = 1;
	}	



}
