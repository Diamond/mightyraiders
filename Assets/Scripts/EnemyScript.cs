using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private GameControllerScript _gcScript;
	public  float                maxHp ;
	public  float				 currentHp;
	public  float 

	void Start() {
		_gcScript = GameObject.Find ("GameController").GetComponent<GameControllerScript>();
	}

	void OnMouseDown() {
		_gcScript.AttackEnemy();
	}

	public void SpawnEnemy() {

	}
}
