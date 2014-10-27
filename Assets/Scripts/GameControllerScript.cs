using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public Text enemyHpDisplay;
	public Text playerDpsDisplay;

	public float enemyHp   = 100.0f;
	public float playerDps = 1.0f;

	private float _timeSinceLastUpdate = 0.0f;

	// Use this for initialization
	void Start () {
		enemyHp = 100.0f;
		enemyHpDisplay.text = "Enemy HP\n" + Mathf.RoundToInt(enemyHp) + "/100";
	}
	
	// Update is called once per frame
	void Update () {
		_timeSinceLastUpdate += Time.deltaTime;
		if (_timeSinceLastUpdate >= 1.0f) {
			_timeSinceLastUpdate = 0.0f;
			AttackEnemy();
		}
	}

	void UpdateDisplay() {
		enemyHpDisplay.text = "Enemy HP\n" + Mathf.RoundToInt(enemyHp) + "/100";
	}

	public void AttackEnemy() {
		enemyHp -= playerDps;
		UpdateDisplay();
	}
}
