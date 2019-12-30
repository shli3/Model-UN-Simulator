using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour {

	public void triggerMenuBehaviour(int i){

		switch(i){
		default:
		case(0):
			SceneManager.LoadScene("Create_Session");
			break;
		case(1):
			SceneManager.LoadScene("Load_Session");
			break;
		case(2):
			Application.Quit();
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#endif
			break;
		}

	}

}
