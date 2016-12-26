using UnityEngine;
using System.Collections;
using ArabicSupport;

//[ExecuteInEditMode] 

public class SetArabic3dText : MonoBehaviour {
	
	public string text;
	
	// Use this for initialization
	void Start () {
		string s =ArabicFixer.Fix(text, true);

		
		gameObject.GetComponent<TextMesh>().text = s;
		Debug.Log(s);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
