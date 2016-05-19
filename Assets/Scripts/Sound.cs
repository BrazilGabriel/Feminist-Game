using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sound : MonoBehaviour {
	public  Sprite musicOn; 
	public Sprite musicOff; 
	public static bool ativo = false;
	private Button myButton;
	// Use this for initialization
	// tentei adicionar no sprite mas tem q ser no source image do butao
	// para altera a imagem
	void Start () {
		myButton = gameObject.GetComponent<Button>();
		if (PlayerPrefs.GetInt("VolumeOn") == 0){
			ativo = true;
		}
		else {
			ativo = false;
		}
	}
	
	// Update is called once per frame
	public void Update () {
		if (ativo)
		{
			AudioListener.volume = 0f;
			myButton.image.overrideSprite = musicOff;
			PlayerPrefs.SetInt("VolumeOn", 0);
		} 
		else 
		{
			AudioListener.volume = 1f;
			myButton.image.overrideSprite = musicOn;			
			PlayerPrefs.SetInt("VolumeOn", 1);
		}
	}
	public void Musica() {
		ativo = !ativo;
	}
}
