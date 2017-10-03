using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicEx05 : MonoBehaviour {

	public GameObject yellowPlayer;
	public GameObject bluePlayer;
	public GameObject redPlayer;
	public bool redWin;
	public bool blueWin;
	public bool yellowWin;

	bool alreadyWin;
	List<string> allScene;
	int levelNumber;

	public GameObject turret;
	public GameObject bulletPrefab;

	float counterBullet;
	float intervalBullet;

	public GameObject limit;

	// Use this for initialization
	void Start () {


		counterBullet = 0;
		intervalBullet = 1.5f;
		levelNumber = 4;
		allScene = new List<string> ();
		allScene.Add ("ex01");
		allScene.Add ("ex02");
		allScene.Add ("ex03");
		allScene.Add ("ex04");
		allScene.Add ("ex05");
		redWin = false;
		blueWin = false;
		yellowWin = false;
		alreadyWin = false;
	}
		

	// Update is called once per frame
	void Update () {
		if (alreadyWin == false) {

			counterBullet += Time.deltaTime;
			if (counterBullet >= intervalBullet) {
				counterBullet = 0;
			GameObject go =	GameObject.Instantiate (bulletPrefab, turret.transform.position, Quaternion.identity);
				go.GetComponent<bulletScript> ().limit = limit;
			}

			if (redPlayer.GetComponent<playerScript_ex05>().win && bluePlayer.GetComponent<playerScript_ex05>().win && yellowPlayer.GetComponent<playerScript_ex05>().win ) {
				Debug.Log ("YOU WIN NICE");
				alreadyWin = true;
				levelNumber++;
				Application.LoadLevel(allScene[levelNumber % 5]);
			}
		}

	}
}
