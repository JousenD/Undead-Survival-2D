﻿using UnityEngine;
using System.Collections;
using JousenD.UndeadSurvival2d.StateMachine.Scriptable;

namespace JousenD.UndeadSurvival2d.StateMachine
{
    public class StateMachineCore : MonoBehaviour
    {
        [SerializeField]
        private StateSO[] _statesSO;

        // Use this for initialization
        void Start()
        {
            Debug.Log("Init StateMachine");
            Debug.Log(_statesSO[0].Name);
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
