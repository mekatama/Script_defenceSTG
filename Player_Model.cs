using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Model : MonoBehaviour{
//	GameObject gameController;			//検索したオブジェクト入れる用
	public GameObject playerModel01;	//自機model
	public GameObject playerModel02;	//自機model
	public GameObject playerModel03;	//自機model
	private int playerBody;				//自機model制御用

	void Start(){
		//SetUpデータをLosdする 値がなかったら０を入れて初期化
		playerBody = PlayerPrefs.GetInt("PlayerBody", 0); 
		Debug.Log("body : " + playerBody);
//		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
		//gcって仮の変数にGameControllerのコンポーネントを入れる
//		GameController gc = gameController.GetComponent<GameController>();
		Debug.Log("body : " + playerBody);
//		gc.playerBody = 2;
		switch(playerBody){
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
