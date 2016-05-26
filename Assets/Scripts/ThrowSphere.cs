using UnityEngine;
using System.Collections;

public class ThrowSphere : MonoBehaviour {
	public GameObject spherePrefab;
	public GameObject target;
	public float initialSpeed;
	private int count = 0;
	private GameManager gm;
	// Use this for initialization
	void Start () {
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		// 左クリックを感知
		if(Input.GetMouseButtonDown(0) && count < gm.numberOfBalls){
			// sphereを複製
			GameObject sphere = (GameObject)Instantiate(spherePrefab, transform.position, transform.rotation);
			// クリックされた座標から単位ベクトルを計算
			var screenMousePosition = Input.mousePosition;
			screenMousePosition.z = 10f; // このままワールド座標に変換するとz:-10となるので補正
			Vector3 direction = Camera.main.ScreenToWorldPoint(screenMousePosition); // スクリーン座標からワールド座標への変換
			direction.z = target.transform.position.z - transform.position.z; // スクリーン座標にはzがないので砲台から的へのzを代入
			sphere.GetComponent<Rigidbody>().velocity = direction * initialSpeed; // 先ほど作ったsphereに初速を加える
			
			count++;
		}
	}
}
