using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageSystem : MonoBehaviour{
	GameObject image;	//gageを入れる用

	void Start(){
		image = GameObject.Find("Image_Gage");	//ゲージ用オブジェクトを探す
	}

	void Update(){
	}

	//()の中身は引数、他のところから数値を得て{}の中で使う
	public void HPDown (float current, int max) {
		//ImageというコンポーネントのfillAmountを取得して操作する
		image.GetComponent<Image>().fillAmount = current / max;
	}
}
