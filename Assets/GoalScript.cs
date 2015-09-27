using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoalScript : MonoBehaviour {
	public Text GoalText;

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			GoalText.text = "Goal!";
		}
	}
}
