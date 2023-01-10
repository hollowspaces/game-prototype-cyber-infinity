using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class UserProgressData
{
    public int Money = 0;
    public Dictionary<string, bool> levels = new Dictionary<string, bool>();
    public List<int> equippedAugment = new List<int>();
    public int lastLevelIndex;
    public int lastCheckpointIndex;
    public int lastDoorIndex;
    public float currentHp;
    public float currentEnergy;

    public UserProgressData()
    {
        Money = 0;
        lastLevelIndex = 0;
        lastCheckpointIndex = 0;
        lastDoorIndex = 0;
        currentHp = 100f;
        currentEnergy = 40f;
    }
}
