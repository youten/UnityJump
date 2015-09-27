using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MeScript : MonoBehaviour {
	public Text MeHeightText;
	private Vector3 defaultPosition;
	private Rigidbody rb;
	private const int JUMP_MAX = 3;
	private int jump;

	// Use this for initialization
	void Start () {
		defaultPosition = transform.position;
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.right.normalized * 3.0f;
		jump = JUMP_MAX;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (jump-- > 0) {
				rb.AddForce(Vector3.up * 600.0f);
			}
		}
		if (0 <= rb.velocity.x  && rb.velocity.x < 3.0f) {
			rb.velocity = transform.right.normalized * 3.0f;
		} else if (-3.0f < rb.velocity.x && rb.velocity.x < 0){
			rb.velocity = transform.right.normalized * -3.0f;
		}

		MeHeightText.text = "Me " + transform.position.y.ToString("#.00") + "m";
    }

	// Message
	void OnBlock() {
		jump = JUMP_MAX;
	}

	// Message
	void OnFloor() {
		transform.position = defaultPosition;
	}

}
