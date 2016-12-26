using UnityEngine;
using System.Collections;
using ArabicSupport;

public class SetArabic3dTextHindu : MonoBehaviour {
	
	public string text;
	
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<TextMesh>().text = ArabicFixer.Fix(text);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
