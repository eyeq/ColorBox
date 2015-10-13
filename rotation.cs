using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {
	float timer = 0;

	float pointX;
	float pointY;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!Input.GetMouseButton(0)) {
			timer += Time.deltaTime;
			if (timer > 0.1f) {
				timer -= 0.1f;
				this.transform.Rotate (0, 0, 0.5f, Space.World);
			}
		}
	}

	void OnMouseDown() {
		pointX = Input.mousePosition.x;
		pointY = Input.mousePosition.y;
	}
	
	void OnMouseDrag() {
		float rotationX = Input.mousePosition.y - pointY;
		float rotationY = pointX - Input.mousePosition.x;
		float rotationZ = 0;
		pointX = Input.mousePosition.x;
		pointY = Input.mousePosition.y;
		this.transform.Rotate(rotationX, rotationY, rotationZ, Space.World);
	}
}
