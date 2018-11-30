using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int AttackPoint;

	private int HealthPoint = 42;

	void ShowStatus() {
		Debug.Log("PlayerのHPは" + HealthPoint.ToString() + "です。");
	}

	void Attack() {
		Debug.Log("Playerの攻撃。APは" + AttackPoint.ToString() + "。");
	}

	void Damage(int dmg) {
		Debug.Log("Playerは" + dmg.ToString() + "のダメージを受けた。");
		HealthPoint -= dmg;
	}
	// Use this for initialization
	void Start () {
		Debug.Log("Playerの残機は" + StaticVars.PlayerLeft.ToString() + "だよ。");
		
		ShowStatus();
		Attack();
		Damage(10);
		ShowStatus();

		StaticVars.PlayerLeft += 1;
		Debug.Log("Playerの残機は" + StaticVars.PlayerLeft.ToString() + "だよ。");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
