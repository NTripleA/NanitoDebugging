﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public static int hp = 12;		//estas 2 lineas las anadi
	public static int maxhp = 12;	//las cambie a static (variables globales)
	public bool damaged;
<<<<<<< HEAD
=======
	public GameObject nanito;
	public bool dead;
>>>>>>> randomBranch



	public void Damage(int damageCount, float respawnPosX, float respawnPosY, bool shield){

		// Set the damaged flag so the screen will flash.
		//damaged = true;
		if (shield == false) {
			hp -= damageCount;
		} else {
			hp += damageCount;
			Debug.Log ("hp");

		}

<<<<<<< HEAD
		if (hp <= 0) {
=======
		if ((dead == true) || (hp <= 0)) {
			Debug.Log("dead");
>>>>>>> randomBranch
			StartCoroutine(Dead (respawnPosX,respawnPosY));
		}

	}
	

//	void OnTriggerEnter2D(Collider2D otherCollider){
//		//is this nanito?
//		FerrofluidScript goo = otherCollider.gameObject.GetComponent<FerrofluidScript> ();
//		FloorScript floor = otherCollider.gameObject.GetComponent<FloorScript> ();
//		if (goo != null || floor != null) {
//			Destroy(goo.gameObject);
//			Destroy(floor.gameObject);
//		}
//	}

	IEnumerator Dead(float respawnPosX, float respawnPosY) {
		Debug.Log ("dead");
<<<<<<< HEAD
		GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(1);
		transform.position = new Vector2 (respawnPosX, respawnPosY);
		Debug.Log ("respawn");
		GetComponent<Renderer>().enabled = true;
=======
		//GetComponent<Renderer>().enabled = false;
		nanito.gameObject.SetActive (false);
		yield return new WaitForSeconds(1);
		nanito.gameObject.SetActive (true);
		nanito.transform.position = new Vector2 (respawnPosX, respawnPosY);
		Debug.Log ("respawn");
		//GetComponent<Renderer>().enabled = true;
>>>>>>> randomBranch
		hp = maxhp;					//cambio
		
	}



}
