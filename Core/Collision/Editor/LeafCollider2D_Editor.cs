﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using ParticlePhysics2D;

[CustomEditor(typeof(LeafCollider2D))]
public class LeafCollider2D_Editor : Editor {

	public override void OnInspectorGUI () {
		DrawDefaultInspector();
		
		
	}
}
