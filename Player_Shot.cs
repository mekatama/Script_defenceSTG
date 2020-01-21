using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shot : MonoBehaviour{
	public GameObject bulletObject = null;			//弾プレハブ
	public Transform bulletStartPosition = null;	//弾の発射位置を取得する

	//bullet発射
	public void PlayerShot(){
		//弾を生成する位置を指定
		Vector3 vecBulletPos = bulletStartPosition.position;
		//弾を生成
		Instantiate(bulletObject, vecBulletPos, transform.rotation);
	}
}
