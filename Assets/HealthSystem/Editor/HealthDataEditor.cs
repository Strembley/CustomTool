using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthData))]
public class HealthDataEditor : Editor
{
   
    private SerializedProperty _maxHealth;
    private SerializedProperty _bleedOut;
    private SerializedProperty _bleedDamage;
    private SerializedProperty _bleedDelay;
    private SerializedProperty _limbLoss;
    private SerializedProperty _arms;
    private SerializedProperty _legs;
    private SerializedProperty _head;
    private SerializedProperty _firstAid;
    private SerializedProperty _stopBleeding;
    private SerializedProperty _medkitHealAmount;
    private SerializedProperty _stopBleedCount;
    private SerializedProperty _bandageHealAmount;
    private SerializedProperty _fixLimbCount;
    private SerializedProperty _splintHealAmount;
    private SerializedProperty _screenEffects;
    private SerializedProperty _flinchEffect;
    private SerializedProperty _healEffect;
    private SerializedProperty _winceEffect;
    private SerializedProperty _concussionEffect;
    private SerializedProperty _affectStats;
    private SerializedProperty _movementSpeed;
    private SerializedProperty _slowIntensity;
    private SerializedProperty _soundEffects;
    private SerializedProperty _flinchSfx;
    private SerializedProperty _medkitSfx;
    private SerializedProperty _bandageSfx;
    private SerializedProperty _splintSfx;

    private void OnEnable()
    {
        _maxHealth = serializedObject.FindProperty("_maxHealth");
        _bleedOut = serializedObject.FindProperty("_bleedOut");
        _bleedDamage = serializedObject.FindProperty("_bleedDamage");
        _bleedDelay = serializedObject.FindProperty("_bleedDelay");
        _limbLoss = serializedObject.FindProperty("_limbLoss");
        _arms = serializedObject.FindProperty("_arms");
        _legs = serializedObject.FindProperty("_legs");
        _head = serializedObject.FindProperty("_head");
        _firstAid = serializedObject.FindProperty("_firstAid");
        _stopBleeding = serializedObject.FindProperty("_stopBleeding");
        _medkitHealAmount = serializedObject.FindProperty("_medkitHealAmount");
        _stopBleedCount = serializedObject.FindProperty("_stopBleedCount");
        _bandageHealAmount = serializedObject.FindProperty("_bandageHealAmount");
        _fixLimbCount = serializedObject.FindProperty("_fixLimbCount");
        _splintHealAmount = serializedObject.FindProperty("_splintHealAmount");
        _screenEffects = serializedObject.FindProperty("_screenEffects");
        _flinchEffect = serializedObject.FindProperty("_flinchEffect");
        _healEffect = serializedObject.FindProperty("_healEffect");
        _winceEffect = serializedObject.FindProperty("_winceEffect");
        _concussionEffect = serializedObject.FindProperty("_concussionEffect");
        _affectStats = serializedObject.FindProperty("_affectStats");
        _movementSpeed = serializedObject.FindProperty("_movementSpeed");
        _slowIntensity = serializedObject.FindProperty("_slowIntensity");
        _soundEffects = serializedObject.FindProperty("_soundEffects");
        _flinchSfx = serializedObject.FindProperty("_flinchSfx");
        _medkitSfx = serializedObject.FindProperty("_medkitSfx");
        _bandageSfx = serializedObject.FindProperty("_bandageSfx");
        _splintSfx = serializedObject.FindProperty("_splintSfx");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.UpdateIfRequiredOrScript();
        
        
        //base.OnInspectorGUI();

        //custom GUI here
        EditorGUILayout.LabelField("General Health Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_maxHealth, new GUIContent("Max Health"));
        EditorGUILayout.Space(20);
        EditorGUILayout.LabelField("General Bleed Settings", EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        EditorGUILayout.PropertyField(_bleedOut, new GUIContent("Bleed Out"));
        
        if (_bleedOut.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced Bleed Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.PropertyField(_bleedDamage, new GUIContent("Bleed Damage"));
            EditorGUILayout.PropertyField(_bleedDelay, new GUIContent("Bleed Delay"));
        }
       
        EditorGUILayout.Space(40);

        EditorGUILayout.LabelField("General Limb Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_limbLoss, new GUIContent("Limb Loss"));
        
        if (_limbLoss.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced Limb Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.PropertyField(_arms, new GUIContent("Arms"));
            EditorGUILayout.PropertyField(_legs, new GUIContent("Legs"));
            EditorGUILayout.PropertyField(_head, new GUIContent("Head"));
        }
        
        EditorGUILayout.Space(40);

        EditorGUILayout.LabelField("General FirstAid Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_firstAid, new GUIContent("First Aid"));
        if (_firstAid.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced FirstAid Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Medkit", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);
            EditorGUILayout.PropertyField(_stopBleeding, new GUIContent("Stop Bleeeding"));
            EditorGUILayout.PropertyField(_medkitHealAmount, new GUIContent("Medkit Heal Amount"));
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Bandage", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);
            EditorGUILayout.PropertyField(_stopBleedCount, new GUIContent("Stop Bleeeding Count"));
            EditorGUILayout.PropertyField(_bandageHealAmount, new GUIContent("Bandage Heal Amount"));
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Splint", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);
            EditorGUILayout.PropertyField(_fixLimbCount, new GUIContent("Fix Limb Count"));
            EditorGUILayout.PropertyField(_splintHealAmount, new GUIContent("Splint Heal Amount"));

            
        }
        
        EditorGUILayout.Space(40);

        EditorGUILayout.LabelField("General Screen Effect Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_screenEffects, new GUIContent("Screen Effects"));
        if (_screenEffects.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced Screen Effect Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.PropertyField(_flinchEffect, new GUIContent("Flinch Effect"));
            EditorGUILayout.PropertyField(_healEffect, new GUIContent("Heal Effect"));
            EditorGUILayout.PropertyField(_winceEffect, new GUIContent("Wince Effect"));
            EditorGUILayout.PropertyField(_concussionEffect, new GUIContent("Concussion Effect"));
        }
        

        EditorGUILayout.Space(40);
        EditorGUILayout.LabelField("General Stats Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_affectStats, new GUIContent("Affect Stats"));
        if (_affectStats.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced Stats Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Movement", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_movementSpeed, new GUIContent("Movement Speed"));
            if (_movementSpeed.boolValue == true)
            {
                EditorGUILayout.Space(10);
                EditorGUI.indentLevel++;
                _slowIntensity.floatValue = EditorGUILayout.Slider("Slow Intensity",_slowIntensity.floatValue, 1, 10);

            }
        }
        EditorGUILayout.Space(40);

        EditorGUILayout.LabelField("General SFX Settings", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_soundEffects, new GUIContent("SFX"));
        if (_soundEffects.boolValue == true)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Advanced SFX Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.PropertyField(_flinchSfx, new GUIContent("Flinch SFX"));
            EditorGUILayout.PropertyField(_medkitSfx, new GUIContent("Medkit SFX"));
            EditorGUILayout.PropertyField(_bandageSfx, new GUIContent("Bandage SFX"));
            EditorGUILayout.PropertyField(_splintSfx, new GUIContent("Splint SFX"));
        }
        


        serializedObject.ApplyModifiedProperties();
    }
}
