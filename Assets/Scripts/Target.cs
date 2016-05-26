using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
	private GameManager gm;
	public GameObject gameManager;
	private int count = 0;

	// Use this for initialization
	void Start () {
		// GameManager.csはGameManegerオブジェクトのコンポーネントのためGetComponentが必要
		gm = gameManager.GetComponent<GameManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision other){
		// 当たった時のボールと的の中心の座標の距離を計算し，スコアを計算する
		gm.score += 100 - (int)(Vector2.Distance(new Vector2(transform.position.x, transform.position.y),
		 new Vector2(other.transform.position.x, other.transform.position.y))*50);
		 count++;
		 if(count == gm.numberOfBalls){
			 gm.endFlag = true;
		 }
	}
}
