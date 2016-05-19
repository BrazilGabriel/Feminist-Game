using UnityEngine;
using System.Collections;

public class BackKey : MonoBehaviour {
	
	// Update is called once per frame
	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.LoadLevel ("Menu");
		}
	}
}