using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	public Transform mainCamera;

	// Update is called once per frame
	void Update () {
		if (mainCamera) {
			Vector3 startPosition = mainCamera.position;
			Vector3 endPosition = new Vector3 (startPosition.x, transform.position.y + 3.0f, startPosition.z);
			mainCamera.position = Vector3.Lerp (startPosition, endPosition, 0.5f);
		}
	}
}
