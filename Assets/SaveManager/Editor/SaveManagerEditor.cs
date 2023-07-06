using System;
using Radgar.SaveManager.Categories;
using UnityEditor;
using UnityEngine;

namespace Radgar.SaveManager.Editor
{
    [CustomEditor(typeof(SaveManager))]
    public class SaveManagerEditor : UnityEditor.Editor
    {
        private SerializedProperty saveTypesProperty;
        private SerializedProperty saveTransformProperty;
        private SerializedProperty saveScoreBoardProperty;

        private void OnEnable()
        {
            saveTypesProperty = serializedObject.FindProperty("_saveTypes");
            saveTransformProperty = serializedObject.FindProperty("_saveTransform");
            saveScoreBoardProperty = serializedObject.FindProperty("_saveScoreBoard");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(saveTypesProperty);

            SaveTypes saveTypes = (SaveTypes)saveTypesProperty.intValue;

            if ((saveTypes & SaveTypes.ObjectsPositions) != 0)
            {
                EditorGUILayout.PropertyField(saveTransformProperty);
            }

            if ((saveTypes & SaveTypes.ScoreBoards) != 0)
            {
                EditorGUILayout.PropertyField(saveScoreBoardProperty); 
                //DrawDefaultInspector();
                SaveManager myTarget = (SaveManager) target;
            
                if (GUILayout.Button("Save Score Board"))
                {
                    //myTarget.SaveData();
                }
            
                if (GUILayout.Button("Load Score Board"))
                {
                    //myTarget.LoadData();
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}