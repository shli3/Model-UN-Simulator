using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class BlinkingText : MonoBehaviour {

	public TextMeshProUGUI words;
	void Start () {

		words = GetComponent<TextMeshProUGUI>();
		StartBlinking();
	}
	
	IEnumerator Blink(){
		
		while(true){
			switch(words.color.a.ToString()){
				case "0":
					words.color = new Color(words.color.r, words.color.g, words.color.b, 1);
					yield return new WaitForSeconds(0.75f);
					break;
				case "1":
					words.color = new Color(words.color.r, words.color.g, words.color.b, 0);
					yield return new WaitForSeconds(0.75f);
					break;
			}
		}
	}

	void StartBlinking(){
		StopCoroutine("Blink");
		StartCoroutine("Blink");
	}
}
