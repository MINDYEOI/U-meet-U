using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(ChatMgr))]
public class ChatEditor : Editor
{
    ChatMgr chatmgr;
    string text;

    private void OnEnable()
    {
        chatmgr = target as ChatMgr;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.BeginHorizontal();
        text = EditorGUILayout.TextArea(text);
        //text = EditorGUILayout.TextArea(inputText.text.ToString());

        if (GUILayout.Button("보내기",GUILayout.Width(60))&& text.Trim()!="")
        {
            chatmgr.Chat(true, text, "나", null);
            text = "";
            GUI.FocusControl(null);
        }
        if (GUILayout.Button("받기", GUILayout.Width(60)) && text.Trim() != "")
        {
            chatmgr.Chat(false, text, "타인", null);
            text = "";
            GUI.FocusControl(null);
        }

        EditorGUILayout.EndHorizontal();
    }
}
