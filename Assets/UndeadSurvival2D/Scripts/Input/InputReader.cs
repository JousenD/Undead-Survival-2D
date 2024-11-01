using System;
using UnityEngine;
using UnityEngine.Events;


namespace JousenD.UndeadSurvival2D.Input
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "Input/Input Reader")]
    public class InputReader : ScriptableObject
    {
        public event UnityAction<Vector2> MoveEvent = delegate { };
        public event UnityAction<bool> EvadeEvent = delegate { };


        public void OnMoveSO(Vector2 value)
        {
            MoveEvent.Invoke(value);
        }

        public void OnEvade(bool value)
        {
            EvadeEvent.Invoke(value);
        }
    }
}