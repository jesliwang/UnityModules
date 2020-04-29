using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityModule{
	[CustomPropertyDrawer(typeof(SortingLayerAttribute))]
	public class SortingLayerDrawer : PropertyDrawer {

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			var index =  SortingLayer.NameToID(property.stringValue);

			string[] stringNames = new string[SortingLayer.layers.Length];
			for(int i = 0; i < stringNames.Length; i++)
				stringNames[i] = SortingLayer.layers[i].name;
			
			index = EditorGUI.Popup(position, label.text, index, stringNames);

			property.stringValue = SortingLayer.IDToName(index);
		}
	}

}

