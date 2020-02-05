using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Fall : MonoBehaviour{
	GameObject gameController;	//検索したオブジェクト入れる用
	private Rigidbody rb;		//入れる用

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
		rb = GetComponent<Rigidbody>();	//取得
		rb.velocity = Vector3.zero;		//強制停止
		rb.isKinematic = true;			//重力もキャンセル
	}

	void Update(){
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		if(gc.isFall == true){
			rb.AddForce(0, 0, 0);		//動けるようにする
			rb.isKinematic = false;		//重力を有効にする
		}
	}
}
