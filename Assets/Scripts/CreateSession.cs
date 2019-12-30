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
public class CreateSession : MonoBehaviour {

	public int counter;
	string[] delegates = new string[200];
	public InputField PotentialD;
	public GameObject prefab;

	public void InsertDelegate(){

		delegates[counter] = PotentialD.text;
		Debug.Log(" " + delegates[counter] + " " + counter);
		counter++;
		
	}

	public void DisplayDelegate(){

		GameObject newObj;

		for(int i = 0; i < counter; i++){


			newObj = (GameObject)Instantiate(prefab, transform);

			newObj.GetComponent<Text>().text = delegates[i];

			
		}

	}

	public void NextScene(){

		SceneManager.LoadScene("Session_Name");

	}

	public void CreateSessionFile(){


	}

}
