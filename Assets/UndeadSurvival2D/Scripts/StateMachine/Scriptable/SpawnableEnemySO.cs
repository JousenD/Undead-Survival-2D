using UnityEngine;
using JousenD.UndeadSurvival2d.Enemy;

namespace JousenD.UndeadSurvival2d.Spawning.Scriptable
{
    [CreateAssetMenu(fileName = "SpawnableEnemySO", menuName = "Spawning/Spawnable Enemy")]
    public class SpawnableEnemySO : SpawnableSO<EnemyBehaviour>
    {
        public override EnemyBehaviour Instantiate(Vector2 position, Transform parent)
        {
            return Object.Instantiate(Prefab, position, Quaternion.identity, parent);
        }
    }
}
