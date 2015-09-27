using UnityEngine;
using System.Collections;

public class UponScript : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player") {
			// Player on the Block
			if (transform.position.y < col.gameObject.transform.position.y) {
				col.gameObject.SendMessage ("OnBlock");
			}
		}
	}
}
