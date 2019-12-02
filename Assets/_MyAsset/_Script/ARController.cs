using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARController : MonoBehaviour {
	private GameObject Picture360List;

	private GameObject Picture360_1,Picture360_2,Picture360_3,Picture360_4,Picture360_5;
	private Button Button01, Button02,Button03,Button04,Button05,BackButton;
	private bool is360;
	// Use this for initialization
	void Start () {
		Picture360List = GameObject.Find("Picture360List");

		Picture360_1 = GameObject.Find("Picture360_1");
		Picture360_2 = GameObject.Find("Picture360_2");
		Picture360_3 = GameObject.Find("Picture360_3");
		Picture360_4 = GameObject.Find("Picture360_4");
		Picture360_5 = GameObject.Find("Picture360_5");
		BackButton = GameObject.Find("BackButton").GetComponent<Button>();


		Button01 = GameObject.Find("Button01").GetComponent<Button>();
		Button02 = GameObject.Find("Button02").GetComponent<Button>();
		Button03 = GameObject.Find("Button03").GetComponent<Button>();
		Button04 = GameObject.Find("Button04").GetComponent<Button>();
		Button05 = GameObject.Find("Button05").GetComponent<Button>();

		Picture360List.SetActive (false);

		Button01.onClick.AddListener(Button01Function);
		Button02.onClick.AddListener(Button02Function);
		Button03.onClick.AddListener(Button03Function);
		Button04.onClick.AddListener(Button04Function);
		Button05.onClick.AddListener(Button05Function);

		BackButton.onClick.AddListener(BackButtonFunction);
	}

	void Button01Function(){
		Current360Photo (1);
	}


	void Button02Function(){
		Current360Photo (2);
	}

	void Button03Function(){
		Current360Photo (3);
	}

	void Button04Function(){
		Current360Photo (4);
	}

	void Button05Function(){
		Current360Photo (5);
	}

	void BackButtonFunction(){
		if (is360 == true) {
			Picture360List.SetActive (false);
		} else {
			Application.LoadLevel ("Scene01");
		}
		is360 = false;
	}

	void Current360Photo(int State360){
		Picture360List.SetActive (true);
		is360 = true;
		Picture360_1.SetActive (false);
		Picture360_2.SetActive (false);
		Picture360_3.SetActive (false);
		Picture360_4.SetActive (false);
		Picture360_5.SetActive (false);

		if (State360 == 1) {
			Picture360_1.SetActive (true);
		}
		if (State360 == 2) {
			Picture360_2.SetActive (true);
		}
		if (State360 == 3) {
			Picture360_3.SetActive (true);
		}
		if (State360 == 4) {
			Picture360_4.SetActive (true);
		}
		if (State360 == 5) {
			Picture360_5.SetActive (true);
		}
	}
}
