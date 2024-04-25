using UnityEngine;
using System.Collections;
using JousenD.UndeadSurvival2D.Player;
using JousenD.UndeadSurvival2d.Character;

namespace JousenD.UndeadSurvival2d.Player
{
    public class PlayerBehaviour : CharacterBehaviour
    {
        private PlayerController _playerController;
        private Animator _animator;

        // Use this for initialization
        new void Start()
        {
            base.Start();
            _playerController = GetComponent<PlayerController>();
            _animator = GetComponentInChildren<Animator>();
        }
        // Update is called once per frame
        void Update()
        {
            if (_playerController.movementInput.x < 0 && !isFacingLeft ||
                _playerController.movementInput.x > 0 && isFacingLeft)
            {
                Flip();
            }

            var speed = Mathf.Round(_playerController.movementBlend * 100f) / 100f;
            _animator.SetFloat("Speed", speed);
        }
    }
}