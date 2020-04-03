using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUpController : MonoBehaviour{
	private int playerBody;		//自機model制御用

	void Start(){
		//SetUpデータをSaveする 値がなかったら０を入れて初期化
//		playerBody = 2;
		PlayerPrefs.SetInt("PlayerBody", playerBody);		//save
	}

	//1用の制御関数
	public void ButtonClicked_1(){
		playerBody = 1;
		PlayerPrefs.SetInt("PlayerBody", playerBody);		//save
	}
	//2用の制御関数
	public void ButtonClicked_2(){
		playerBody = 2;
		PlayerPrefs.SetInt("PlayerBody", playerBody);		//save
	}
	//3用の制御関数
	public void ButtonClicked_3(){
		playerBody = 3;
		PlayerPrefs.SetInt("PlayerBody", playerBody);		//save
	}

	//return用の制御関数
	public void ButtonClicked_Return(){
		SceneManager.LoadScene("title");	//シーンのロード
	}
}
