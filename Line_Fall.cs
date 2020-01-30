using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Fall : MonoBehaviour{
	private Rigidbody rb;	//入れる用
//rigidbody.velocity = Vector3.zero;
	void Start(){
		rb = GetComponent<Rigidbody>();	//取得
		rb.velocity = Vector3.zero;		//強制停止
		rb.isKinematic = true;			//重力もキャンセル
	}

	void Update(){
	}
}
