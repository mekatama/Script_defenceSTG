using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//cameraにMainCameraタグをアサイン忘れるな
public class Player : MonoBehaviour{
	GameObject gameController;	//検索したオブジェクト入れる用
	public bool isWallHit_R;//wall hit flag
	public bool isWallHit_L;//wall hit flag
	GameObject tapObj;		//tapしたオブジェクト入れる用
	public bool isStop;		//stop flag
	public int stopCountMax;//stopできるMAXカウント
	public int stopCount;	//カウント用 
	GameObject gageSystem;	//ゲージ用オブジェクト入れる用

		float currentHP;
		int maxHP;

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerを探す
		isWallHit_R = false;//初期化
		isWallHit_L = true;	//初期化、右に移動したい
		isStop = false;		//初期化
		stopCount = stopCountMax;
		gageSystem = GameObject.Find("GageSystem");
	}
	void Update () {
		//タップした判定
 		if(Input.GetMouseButtonDown(0)){
			Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				tapObj = hit.collider.gameObject;	//tapしたobject取得
			}else{
				tapObj = null;						//object以外をタッチした扱い
			}

			//tapObjがタッチされた時判定。error対策
			if(tapObj != null){
				//Playerをtapしたら
				if(tapObj.tag == "Player"){
					isStop = true;
					Debug.Log("touch");
				}
			}
		}
		//離した判定
 		if(Input.GetMouseButtonUp(0)){
			Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				tapObj = hit.collider.gameObject;	//tapしたobject取得
			}else{
				tapObj = null;						//object以外をタッチした扱い
			}

			//tapObjが離した時判定。error対策
			if(tapObj != null){
				//Playerをtapしたら
				if(tapObj.tag == "Player"){
					isStop = false;
					Debug.Log("hanasita");
				}
			}
		}

		//stopカウント処理
		if(isStop == true){
			stopCount -= 1;		//カウント減算
		}
		if(isStop == false && stopCount < stopCountMax){
			stopCount += 1;					//カウント加算
			if(stopCount >= stopCountMax){
				stopCount = stopCountMax;	//カウントMAX以上にしない
			}
		}

		//HPSystemのスクリプトのHPDown関数に2つの数値を送る
		gageSystem.GetComponent<GageSystem>().HPDown(currentHP, maxHP);
		currentHP = stopCount;
		maxHP = stopCountMax;
	}


	//他のオブジェクトとの当たり判定
	void OnTriggerEnter( Collider other) {
		if(other.tag == "Wall_R"){
			isWallHit_R = true;
			isWallHit_L = false;
		}
		if(other.tag == "Wall_L"){
			isWallHit_R = false;
			isWallHit_L = true;
		}
		if(other.tag == "Item_Bom"){
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			GameController gc = gameController.GetComponent<GameController>();
			gc.bomNum ++;				//Bom残弾加算
			Debug.Log("Bom:" + gc.bomNum);
			Destroy(other.gameObject);	//相手のGameObjectを［Hierrchy］ビューから削除する
		}
	}
}
