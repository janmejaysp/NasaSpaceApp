﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour {

	public void changemenuscene(string scenename)
	{
		Application.LoadLevel(scenename);
	}
}
