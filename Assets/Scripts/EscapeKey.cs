using UnityEngine;
using System.Collections;

public class EscapeKey : MonoBehaviour {
	bool controlPause =true;
	Canvas canvas;
	Canvas canvas1;
	// Update is called once per frame
	void Start () {
		canvas1 = GameObject.Find ("CanvasM").GetComponent<Canvas> ();
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
		canvas1.enabled = true;
	}

	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			canvasOnOff();
		}
	}
	public void canvasOnOff(){
		if (controlPause) {
			canvas.enabled = true;
			canvas1.enabled = false;
			controlPause = false;
		} else {
			canvas.enabled = false;			
			canvas1.enabled = true;
			controlPause = true;
		}
	}
	public void Quit(){
		Application.Quit();
	}
}