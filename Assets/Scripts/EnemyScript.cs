using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private GameControllerScript _gcScript;
	public  float                maxHp ;
	public  float				 currentHp;
	public  int                  level = 1;

	void Start() {
		_gcScript = GameObject.Find ("GameController").GetComponent<GameControllerScript>();
	}

	void OnMouseDown() {
		_gcScript.AttackEnemy();
	}

	public void SpawnEnemy() {
		maxHp = 10.0f + (level * 2.5f);
		currentHp = maxHp;
	}
}
