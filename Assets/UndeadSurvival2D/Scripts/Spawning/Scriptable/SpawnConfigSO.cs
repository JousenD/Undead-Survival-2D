using System;
using System.Collections.Generic;
using UnityEngine;

namespace JousenD.UndeadSurvival2d.Spawning.Scriptable
{
    [CreateAssetMenu(fileName = "SpawnConfigSO", menuName = "Spawning/Spawn Config")]
    public class SpawnConfigSO : ScriptableObject
    {
        public float SpawnIntervalTime;

        public List<SpawnConfig> Waves;

        [Serializable]
        public struct SpawnConfig
        {
            public SpawnableEnemySO EntityToSpawn;
            public float RoundTime;
        }
    }
}
