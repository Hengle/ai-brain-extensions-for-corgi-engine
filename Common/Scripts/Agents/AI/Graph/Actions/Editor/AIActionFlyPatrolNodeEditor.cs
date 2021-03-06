﻿using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionFlyPatrolNode))]
    public class AIActionFlyPatrolNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _changeDirectionOnObstacle;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _changeDirectionOnObstacle = serializedObject.FindProperty("changeDirectionOnObstacle");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 170;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnObstacle);
            serializedObject.ApplyModifiedProperties();
        }
    }
}