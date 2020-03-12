using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_IGameBomNum : MonoBehaviour{
	public GameObject gameController;	//GameController取得
	public Text bomNumText;				//Textコンポーネント取得用

	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		//Bom数表示
		bomNumText.text = "BOM : " + gc.bomNum.ToString("000000");
	}
}
