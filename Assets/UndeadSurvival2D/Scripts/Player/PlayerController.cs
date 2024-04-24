using UnityEngine;
using System.Collections;
using JousenD.UndeadSurvival2D.Input;

namespace JousenD.UndeadSurvival2D.Player
{
    public class PlayerController : MonoBehaviour
    {
        public Vector2 movementInput;
        public Vector3 movementVector;

        public float targetSpeed = 2f;

        [SerializeField]
        private InputReader _inputReader;
        private void OnEnable()
        {
            _inputReader.MoveEvent += OnMoveEvent;
        }
        private void OnDisable()
        {
            _inputReader.MoveEvent -= OnMoveEvent;
        }
        // Update is called once per frame
        void Update()
        {
            ComputeMovement();
            Move();
        }

        private void Move()
        {
            transform.position += movementVector;
        }

        private void ComputeMovement()
        {

            var move = new Vector3(movementInput.x, movementInput.y, 0);
            movementVector = targetSpeed * Time.deltaTime * move;
        }

        private void OnMoveEvent(Vector2 move)
        {
            movementInput = move;
        }
    }
}
