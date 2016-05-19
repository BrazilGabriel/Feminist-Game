using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {
	// Update is called once per frame

	public  void Menu(){ 
		Application.LoadLevel ("Menu");
	}
	public void About(){
		Application.LoadLevel("About");
	}
	public void SelectLevel(){	
		Time.timeScale = 1;
		Application.LoadLevel("SelectLevel");
	}	
	public void ReloadLevel(){	
		Time.timeScale = 1;
		Application.LoadLevel(PlayerPrefs.GetInt("currentStage")+4);
	}

	//SELEÇAO DE NIVEIS
	public void Stage01(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage01");
	}

	public void Stage02(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage02");
	}
	
	public void Stage03(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage03");
	}
	
	public void Stage04(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage04");
	}
	
	public void Stage05(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage05");
	}

	public void Stage06(){
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel("Stage06");
	}

	public void NextStage(){		
		Destroy(GameObject.Find ("MUSIC"));
		Application.LoadLevel(PlayerPrefs.GetInt("currentStage")+5);
	}
}
