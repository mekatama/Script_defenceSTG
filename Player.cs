using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//cameraにMainCameraタグをアサイン忘れるな
public class Player : MonoBehaviour{
	public bool isWallHit_R;//wall hit flag
	public bool isWallHit_L;//wall hit flag
	GameObject tapObj;		//tapしたオブジェクト入れる用
	public bool isStop;		//stop flag

	void Start(){
		isWallHit_R = false;//初期化
		isWallHit_L = true;	//初期化、右に移動したい
		isStop = false;		//初期化
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
	}
}
