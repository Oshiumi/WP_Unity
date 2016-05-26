using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// 持ち球の数
	public int numberOfBalls = 10; 
	// スコア
	public int score;
	private float timer = 0f;
	public bool endFlag = false;
	
	void Start () {
		score = 0;
	}
	
	void Update () {
		// 時間の計算
		timer += Time.deltaTime;
		// 時間が60s以上になったらendというラベルを表示
		if(timer > 60f){
			endFlag = true;
		}
	}
	
	void SetScore(int score){
		this.score = score;
	}
}
