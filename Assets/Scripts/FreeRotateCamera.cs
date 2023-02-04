using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeRotateCamera : MonoBehaviour
{

	public Vector2 direction;

	// Start is called before the first frame update
	void Start()
	{
		direction = new Vector2(0.0f, 0.0f);
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update()
	{
		direction.x += Input.GetAxis("Mouse X");
		direction.y += Input.GetAxis("Mouse Y");
		transform.localRotation = Quaternion.Euler(-direction.y * 0, direction.x, 0);
	}
}
