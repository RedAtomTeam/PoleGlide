using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatsConfig", menuName = "Scriptable Objects/StatsConfig")]
public class StoreStuff : ScriptableObject
{
    public List<LevelConfig> levelConfigs;
    public int distance;
}
