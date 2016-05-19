using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {
	
	public float timer = 1f;
	public string levelToLoad = "Menu";
	
	
	// Use this for initialization
	void Start () {
		StartCoroutine ("DisplayScene");
	}
	
	IEnumerator DisplayScene(){
		yield return new WaitForSeconds(timer);
		Application.LoadLevel (levelToLoad);
	}
}