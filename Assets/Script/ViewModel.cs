﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewModel : MonoBehaviour
{
			public void Button_Click(string scenename)
			{
        Application.LoadLevel(scenename);
			}
}
