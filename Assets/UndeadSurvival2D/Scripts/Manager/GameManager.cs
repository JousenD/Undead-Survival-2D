﻿using UnityEngine;
using JousenD.UndeadSurvival2d.Player;

namespace JousenD.UndeadSurvival2d.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField]
        private PlayerBehaviour _player;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public PlayerBehaviour GetPlayer()
        {
            return _player;
        }
    }
}