﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
  
	}

    public void ChangeColor()
    {
        
    }

    public void ChangeMesh(Mesh mesh)
    {
        gameObject.GetComponent<MeshFilter>().mesh = mesh;
    }
}
