using UnityEngine;
using System.Collections;

public class Label : MonoBehaviour {
	public GUIText scoreGUIText; 
	public GUIText endGUIText;
	public GameObject gameManager;
	private GameManager gm;
	
	void Start () {
		gm = gameManager.GetComponent<GameManager>();
	}
	
	void Update () {
		scoreGUIText.text = "Score: " + gm.score;
		if(gm.endFlag){
			endGUIText.text = "E N D\nScore: " + gm.score;
		}
	}
}
