using System;
using NUnit.Framework.Internal.Commands;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
	[SerializeField] private GameObject camera1;
	[SerializeField] private GameObject camera2;

	private bool using1 = true;


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Apply();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.C)) Toggle();
	}

	public void Toggle()
	{
		using1 = !using1;
		Apply();
	}

	public void Select1()
	{
		using1 = true;
		Apply();
	}

	public void Select2()
	{
		using1 = false;
		Apply();
	}

	private void Apply()
	{
		camera1.SetActive(using1);
		camera2.SetActive(!using1);
	}
}
