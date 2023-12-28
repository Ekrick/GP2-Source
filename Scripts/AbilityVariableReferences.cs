using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AbilityVariableReferences : ScriptableObject
{
    [SerializeField] List<DotBuffVariables> buffVariables = new();
    [SerializeField] FloatVariable Fire_Dot_Frequency;
}
[System.Serializable]
public class DotBuffVariables
{
    [SerializeField] public int tickAmount;
    [SerializeField] public float tickFrequency;
}
public enum BuffType
{
    FIRE_DOT,
    STORM_DOT,
}