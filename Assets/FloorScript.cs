using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FloorScript : MonoBehaviour {
    public Text FloorHightText;
	private Vector3 defaultPosition;

	// stage
	private const int MAX_BLOCKS = 285;
	private GameObject blockPrefab;
	private GameObject[] blocks = new GameObject[MAX_BLOCKS];    
    
	void Start() {
		blockPrefab = (GameObject) Resources.Load("Block");
        defaultPosition = transform.position;
		resetStage();
    }
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * 0.03f);

		FloorHightText.text = "Floor " + transform.position.y.ToString("#.00") + "m";
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player") {
			col.gameObject.SendMessage ("OnFloor");
			transform.position = defaultPosition;
			resetStage();
		}
	}

	void resetStage() {
		for (int i = 0; i < MAX_BLOCKS; i++) {
			if (blocks[i] != null) {
				Destroy(blocks[i]);
			}
			
			// position
			Vector3 pos = new Vector3(
				Random.Range(-8.0f, 8.0f), i * 3.5f + Random.Range(-1.0f, 1.0f), 0);
			blocks[i] = (GameObject) Instantiate(blockPrefab, pos, transform.rotation);
			blocks[i].transform.localScale = new Vector3(
                Random.Range(3.0f, 6.0f), 1.0f, 1.0f);
        }
	}
}
