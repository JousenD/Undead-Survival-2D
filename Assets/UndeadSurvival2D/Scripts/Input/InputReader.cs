using System;
using UnityEngine;


namespace JousenD.UndeadSurvival2D.Input
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "Input/Input Reader")]
    public class InputReader : ScriptableObject
    {
        public void OnMove(Vector2 value)
        {
            Debug.Log("Moving: " + value);
        }
    }
}