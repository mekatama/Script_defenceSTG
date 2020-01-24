using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour{
	GameObject gameController;	//検索したオブジェクト入れる用
	public float speed = 0.0f;	//移動speed

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
	}

	void Update(){
		//移動
			transform.position += transform.up * speed * Time.deltaTime;
	}
	//他のオブジェクトとの当たり判定
	void OnTriggerEnter( Collider other) {
		if(other.tag == "Wall_Up"){
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			GameController gc = gameController.GetComponent<GameController>();
			//画面内の弾数を減算
			gc.shotNum --;
			Destroy(gameObject);	//このGameObjectを［Hierrchy］ビューから削除する
		}
	}
}
