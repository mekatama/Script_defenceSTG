﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour{
	public float speed = 0.0f;	//移動speed

	void Start(){
	}

	void Update(){
		//移動
			transform.position += transform.up * speed * Time.deltaTime;
	}
	//他のオブジェクトとの当たり判定
	void OnTriggerEnter( Collider other) {
		if(other.tag == "Wall_Up"){
			Destroy(gameObject);	//このGameObjectを［Hierrchy］ビューから削除する
		}
	}
}
