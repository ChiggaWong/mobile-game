using UnityEngine;
using System.Collections;


public class Bullet : MonoBehaviour {

	public GameObject[] colorsGO;

	public Ball.BALL_TYPE type;

	public void SetType (Ball.BALL_TYPE type) {

		foreach (var go in colorsGO) {
			go.SetActive(false);
		}

		this.type = type;

		colorsGO [(int)type].SetActive (true);
	}

}
