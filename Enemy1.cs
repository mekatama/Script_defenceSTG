using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour{
	GameObject gameController;	//検索したオブジェクト入れる用
	private bool isTouch;		//接触flag
	private bool isDead;		//死亡flag

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
		isTouch = false;	//初期化
		isDead = false;		//初期化
	}

	//他のオブジェクトとの当たり判定(triger)
	void OnTriggerEnter( Collider other) {
		if(other.tag == "Bullet"){
			isDead = true;
			//lineから離れた判定
			if(isTouch == true){
				if(isDead == true){
					//gcって仮の変数にGameControllerのコンポーネントを入れる
					GameController gc = gameController.GetComponent<GameController>();
					//Line上の敵数を減算
					gc.lineEnemyNum --;
					Debug.Log("linehanareru:" + gc.lineEnemyNum);
					isTouch = false;
				}
			}
			Destroy(gameObject);	//このGameObjectを［Hierrchy］ビューから削除する
		}
		if(other.tag == "Bom"){
			isDead = true;
			Destroy(gameObject);	//このGameObjectを［Hierrchy］ビューから削除する
		}
		if(other.tag == "Line"){
			if(isTouch == false){
				//gcって仮の変数にGameControllerのコンポーネントを入れる
				GameController gc = gameController.GetComponent<GameController>();
				//Line上の敵数を加算
				gc.lineEnemyNum ++;
//				Debug.Log("lineTouch:" + gc.lineEnemyNum);
				isTouch = true;
			}
		}
	}
}
