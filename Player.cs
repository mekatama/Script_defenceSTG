using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
	public bool isWallHit_R;//wall hit flag
	public bool isWallHit_L;//wall hit flag

	void Start(){
		isWallHit_R = false;//初期化
		isWallHit_L = true;//初期化、右に移動したい
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
