using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			Vector3 playerPosition = other.gameObject.transform.position;
			if (playerPosition.x < -9.0f) {
				// Left Wall
				other.gameObject.transform.position = new Vector3(8.0f, playerPosition.y, playerPosition.z);
			} else if (playerPosition.x > 9.0f) {
				// Right Wall
				other.gameObject.transform.position = new Vector3(-8.0f, playerPosition.y, playerPosition.z);
			}
		}
	}
}
