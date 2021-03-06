﻿using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	public Vector2 velocityBall = new Vector2 (0, -0);
	public float _acceleration = 0.5f;
	public float maxcima;
	public float maxbaixo;
	public static int score = 0;
	public static int highScore = 0;
	bool playedUp;	
	bool playedDown;
	bool play;

	void Start (){
		playedUp = false;
		playedDown = true;
        score = 0;

		InvokeRepeating ("scoreUpdate", 0.5f, 0.5f);
	}
	// Update is called once per frame
	void Update () {
		
		//Verifica se o personagem esta subindo ou descendo
		if (Input.GetMouseButton (0)) {			
			playedDown = false;
			GetComponent<Rigidbody2D> ().velocity = -velocityBall * _acceleration;			
			if (!playedUp && play){
				play = false;
			}
			playedUp = true;

		} else {
			playedUp = false;
			GetComponent<Rigidbody2D> ().velocity = velocityBall * _acceleration/1.5f;	
			if (!playedDown && play){		
				play = false;
			}
			playedDown = true;
		}
		
		//Reseta a aceleracao quando o personagem troca a direcao
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonUp (0)) {
			_acceleration = 1f;
		}
		
		//Determina um limite para o valor da aceleracao
		if (_acceleration > 10) {
			_acceleration = 10;
		}
		
		//Aumenta o valor da aceleracao em 0.1 a cada frame
		_acceleration = _acceleration + 0.1f;
		
		//Mantem o personagem dentro da tela
		if (transform.position.y >= maxcima) {			
			transform.position = new Vector2 (transform.position.x, maxcima);
		}
		
		if (transform.position.y <= maxbaixo) {			
			transform.position = new Vector2 (transform.position.x, maxbaixo);
		}
	}

	void scoreUpdate(){
		score += 1;
	}
}