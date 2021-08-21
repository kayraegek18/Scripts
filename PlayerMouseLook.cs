using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseLook : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public Transform playerBody;
	float xRot = 0f;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		xRot -= mouseY;
		xRot = Mathf.Clamp(xRot, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
		playerBody.Rotate(Vector3.up * mouseX);
	}
}

/*
 * Copyright © Gameiva 2021-2022
*/
