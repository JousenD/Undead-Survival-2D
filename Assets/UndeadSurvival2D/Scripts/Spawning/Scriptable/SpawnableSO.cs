using UnityEngine;

namespace JousenD.UndeadSurvival2d.Spawning.Scriptable
{
    public abstract class SpawnableSO<T> : ScriptableObject
    {
        public T Prefab;
        public abstract T Instantiate(Vector2 position, Transform parent);
    }
}