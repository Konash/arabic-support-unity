﻿using UnityEngine;
using UnityEngine.Assertions;
using System.Collections;

public class ArabicSupportTester : MonoBehaviour {

	public ExpectedFixedText[] ExpectedTexts;

	void Start()
	{
		foreach (var expectedText in ExpectedTexts)
		{
			expectedText.Fix();
			Assert.AreEqual(expectedText.Expected, expectedText.Fixed);
		}
	}
}
