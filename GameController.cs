using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
	public int shotNum;		//画面内の弾数
	public int shotNumMax;	//画面内の弾数MAX
	public bool isShot;		//発射flag

	void Start(){
		shotNum = 0;	//初期化
		isShot = false;	//初期化
	}

	void Update(){
		Debug.Log("shot:" + isShot);
		//画面内の弾数で攻撃可能か判定
		if(shotNum >= shotNumMax){
			isShot = false;
		}
		
		if(shotNum < shotNumMax){
			isShot = true;
		}
	}
}
