using System;
using UnityEngine;

[Serializable]
public class Attack
{
    [field: SerializeField] public string AnimationName { get; private set; }

    [field: SerializeField] public float TransistionDuration { get; private set; }

    [field: SerializeField] public int ComboStateIndex { get; private set; } = -1; // index of next attack

    [field: SerializeField] public float ComboAttackTime { get; private set; } // how far you should be through attack before you can start next attack

    [field: SerializeField] public float ForceTime { get; private set; }

    [field: SerializeField] public float Force { get; private set; }





}