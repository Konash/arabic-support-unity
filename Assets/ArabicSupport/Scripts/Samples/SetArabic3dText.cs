using UnityEngine;
using System.Collections;
using ArabicSupport;

//[ExecuteInEditMode] 

public class SetArabic3dText : MonoBehaviour {

	[TextArea]
	public string text;

	public bool ShowTashkeel = false;
	public bool UseHinduNumbers = true;

	// Use this for initialization
	void Start () {
		string s = ArabicFixer.Fix(text, ShowTashkeel, UseHinduNumbers);


		
		gameObject.GetComponent<TextMesh>().text = s;
		Debug.Log(s);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
