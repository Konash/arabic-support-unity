using UnityEngine;
using System.Collections;
using ArabicSupport;

public class SetArabicText : MonoBehaviour {
	
	public string text;
	
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<GUIText>().text = ArabicFixer.Fix(text);
	}

}
