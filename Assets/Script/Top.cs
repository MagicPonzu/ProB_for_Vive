using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour {

	public static int speedNum;

	//最初に何も押されなかった時,speedNum = 5にする
	void Start () {
		if(speedNum == 0) {
			speedNum = 5;
		}
	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.Alpha1)) {
			speedNum = 1;
		} else if(Input.GetKeyUp(KeyCode.Alpha2)) {
			speedNum = 2;
		} else if(Input.GetKeyUp(KeyCode.Alpha3)) {
			speedNum = 3;
		} else if(Input.GetKeyUp(KeyCode.Alpha4)) {
			speedNum = 4;
		} else if(Input.GetKeyUp(KeyCode.Alpha5)) {
			speedNum = 5;
		} else if(Input.GetKeyUp(KeyCode.Alpha6)) {
			speedNum = 6;
		} else if(Input.GetKeyUp(KeyCode.Alpha7)) {
			speedNum = 7;
		} else if(Input.GetKeyUp(KeyCode.Alpha8)) {
			speedNum = 8;
		} else if(Input.GetKeyUp(KeyCode.Alpha9)) {
			speedNum = 9;
		}
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("NoteSpeed:" + speedNum);
			SceneManager.LoadScene ("MainScene");
		}
	}
}
