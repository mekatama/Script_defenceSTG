using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Model : MonoBehaviour{
	public GameObject playerModel01;	//自機model
	public GameObject playerModel02;	//自機model
	public GameObject playerModel03;	//自機model
	private int playerVer;				//自機model制御用

	void Start(){
		playerVer = 2;
		switch(playerVer){
			case 1:
				Destroy(playerModel02);
				Destroy(playerModel03);
				break;
			case 2:
				Destroy(playerModel01);
				Destroy(playerModel03);
				break;
			case 3:
				Destroy(playerModel01);
				Destroy(playerModel02);
				break;
		}
	}

	void Update(){
	}
}
