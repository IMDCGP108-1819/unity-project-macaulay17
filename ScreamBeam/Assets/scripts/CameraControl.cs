using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform Player;

	void LateUpdate () {
        float playerX = Player.position.x;
        transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
	}
}
