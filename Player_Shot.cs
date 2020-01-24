using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shot : MonoBehaviour{
	GameObject gameController;						//検索したオブジェクト入れる用
	public GameObject bulletObject = null;			//弾プレハブ
	public Transform bulletStartPosition = null;	//弾の発射位置を取得する

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
	}

	//bullet発射
	public void PlayerShot(){
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		if(gc.isShot){
			//弾を生成する位置を指定
			Vector3 vecBulletPos = bulletStartPosition.position;
			//弾を生成
			Instantiate(bulletObject, vecBulletPos, transform.rotation);
			//画面内の弾数を加算
			gc.shotNum ++;
		}
	}
}
