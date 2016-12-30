using UnityEngine;
using System.Collections;
using ArabicSupport;

public class SetArabicText : MonoBehaviour {

	[TextArea]
	public string text;
	
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<GUIText>().text = ArabicFixer.Fix(text);
		//gameObject.guiText.fontSize = 60;
				Debug.Log(ArabicSupport.ArabicFixer.Fix("نص عربي على يونيتي، أهلا وسهلا"));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
