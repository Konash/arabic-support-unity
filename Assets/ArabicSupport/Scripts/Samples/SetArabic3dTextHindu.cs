using UnityEngine;
using System.Collections;
using ArabicSupport;

public class SetArabic3dTextHindu : MonoBehaviour {

	[TextArea]
	public string text;

	public bool ShowTashkeel = false;
	public bool UseHinduNumbers = true;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<TextMesh>().text = ArabicFixer.Fix(text, ShowTashkeel, UseHinduNumbers);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
