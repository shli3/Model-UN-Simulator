using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
Allows User to create session.
Stores contents in scrollview into file to be accessed in LoadSession
Must also display user input in scrollview
*/
public class CreateSession : UNDelegate {

	int counter;
	UNDelegate[] delegates = new UNDelegate[200];
	public InputField PotentialD;
	public GameObject prefab;

	public void InsertDelegate(){
		delegates[counter] = new UNDelegate(PotentialD.text);
		counter++;
		DisplayDelegate();
	}

	public void DisplayDelegate(){
		GameObject newObj = new GameObject();

		for(int i = 0; i < counter; i++){
			Debug.Log("" + delegates[i].country + "");
			newObj.GetComponent<Text>().text = delegates[i].country;
		}
	}
}
