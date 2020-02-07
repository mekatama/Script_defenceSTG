using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour{
	private Player childScript;	//Player.csスクリプトを入れる用
	public float speed = 3.0f;	//移動speed

	void Start(){
		//下の階層のオブジェクトにアタッチしている(Player.cs)を参照
		childScript = GetComponentInChildren<Player>();
	}

	void Update(){
		//isStopで移動するかどうか判定する
		if(childScript.isStop == false){
			//右の壁に接触したら
			if(childScript.isWallHit_R == true){
				//左移動
				transform.position -= transform.right * speed * Time.deltaTime;
			}

			//左の壁に接触したら
			if(childScript.isWallHit_L == true){
				//右移動
				transform.position += transform.right * speed * Time.deltaTime;
			}
		}
	}
}
