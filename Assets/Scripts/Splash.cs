using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Splash : MonoBehaviour {

	IEnumerator splashLogo() {
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene ("Menu");
	}

	void Start () {
		StartCoroutine (splashLogo());
	}
	
}
