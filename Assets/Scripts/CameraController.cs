using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float rotationSpeed = 50f;

	private void Update () {
		this.transform.Rotate (Vector3.right * Time.deltaTime * rotationSpeed);
	}
}
