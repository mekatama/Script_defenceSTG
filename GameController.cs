using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
	public int shotNum;		//画面内の弾数
	public int shotNumMax;	//画面内の弾数MAX
	public bool isShot;		//発射flag
	public int lineEnemyNum;//防衛線に乗っている敵の数
	public bool isFall;		//落下flag
	public int bomNum;		//Bomの残弾数
	public bool isBom;		//Bom発射flag
	public float penaltyTime;	//speeDownする時間
	private float timeElapsed;	//時間を仮に格納する変数
	public bool isPenalty;		//penalty flag

	void Start(){
		shotNum = 0;		//初期化
		isShot = false;		//初期化
		lineEnemyNum = 0;	//初期化
		isFall = false;		//初期化
		isBom = true;		//初期化
		isPenalty = false;	//初期化
	}

	void Update(){
		//画面内の弾数で攻撃可能か判定
		if(shotNum >= shotNumMax){
			isShot = false;
		}
		
		if(shotNum < shotNumMax){
			isShot = true;
		}

		//防衛線落下判定
		if(lineEnemyNum >= 3){
			isFall = true;
		}

		//Bom発射判定
		if(bomNum > 0){
			isBom = true;
		}else{
			isBom = false;
		}

		//Penaltyのカウント
		if(isPenalty == true){
			timeElapsed += Time.deltaTime;	//経過時間の保存
			if(timeElapsed >= penaltyTime){	//指定した経過時間に達したら
				isPenalty = false;			//penalty終了
			}
		}

	}
}
