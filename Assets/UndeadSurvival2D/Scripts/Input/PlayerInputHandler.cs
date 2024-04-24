﻿using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

namespace JousenD.UndeadSurvival2D.Input
{
    public class PlayerInputHandler : MonoBehaviour
    {
         [SerializeField]
        private InputReader _inputReader;

        public void OnMove(InputValue value)
        {
            _inputReader.OnMoveSO(value.Get<Vector2>());
        }
    }
}
