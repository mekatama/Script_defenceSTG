using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour{
	GameObject gameController;		//検索したオブジェクト入れる用
	private Player childScript;		//Player.csスクリプトを入れる用
	public float speed = 3.0f;		//移動speed
	public float speedDown = 1.0f;	//speedDown時の移動speed
	private float tmpSpeed;			//speedを入れる用
	public Canvas Canvas_InGame2;	//speed down UI

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
		//下の階層のオブジェクトにアタッチしている(Player.cs)を参照
		childScript = GetComponentInChildren<Player>();
		Canvas_InGame2.enabled = false;	//UI非表示
	}

	void Update(){
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		//isPenaltyを見て、speed変化
		if(gc.isPenalty == false){
			tmpSpeed = speed;
			Canvas_InGame2.enabled = false;	//UI非表示
		}else{
			tmpSpeed = speedDown;
			Canvas_InGame2.enabled = true;	//UI表示
		}

		//isStopで移動するかどうか判定する
		if(childScript.isStop == false){
			//右の壁に接触したら
			if(childScript.isWallHit_R == true){
				//左移動
				transform.position -= transform.right * tmpSpeed * Time.deltaTime;
			}

			//左の壁に接触したら
			if(childScript.isWallHit_L == true){
				//右移動
				transform.position += transform.right * tmpSpeed * Time.deltaTime;
			}
		}
	}
}
