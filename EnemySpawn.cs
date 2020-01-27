using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour{
	public GameObject[] enemyObject;	//enemyのプレハブを配列で管理
	public float timeOut;				//enemyを出現させたい時間間隔
	private float timeElapsed;			//時間を仮に格納する変数
	private int enemyType;				//enemyの種類
	public GameObject enemy;

	void Start () {
		enemyType = 0;	//(仮)enemyの種類
		enemy = null;	//初期化
	}

	void Update () {
		//時間チェック
		timeElapsed += Time.deltaTime;	//経過時間の保存
        if(timeElapsed >= timeOut) {	//指定した経過時間に達したら
			enemyGo();					//enemy生成
		}
	}

	public void enemyGo(){
		float x_pos = Random.Range(-2.0f,2.0f); //ランダムで出現位置を決める

		//enemyを生成する
		enemy = (GameObject)Instantiate(
			enemyObject[enemyType],	//■仮で0を入れている。0～4を想定
			new Vector3(x_pos, transform.position.y, transform.position.z),
			transform.rotation
		);
		timeElapsed = 0.0f;			//生成時間リセット
	}

}
