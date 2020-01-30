using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour{
	//他のオブジェクトとの当たり判定(triger)
	void OnTriggerEnter( Collider other) {
		if(other.tag == "Bullet"){
			Destroy(gameObject);	//このGameObjectを［Hierrchy］ビューから削除する
		}
	}
}
