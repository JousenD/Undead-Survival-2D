using UnityEngine;
using System.Collections;
using JousenD.UndeadSurvival2D.Input;
using JousenD.UndeadSurvival2d.Abilities;


namespace JousenD.UndeadSurvival2d.Player
{
    public class PlayerController : MonoBehaviour
    {
        public float TargetSpeed;
        public Vector2 movementInput;
        public Vector3 movementVector;

        public float movementBlend;
        public float speedModifier;



        [SerializeField]
        private InputReader _inputReader;
        private AbilityRunner _abilityRunner;
        private void OnEnable()
        {
            _inputReader.MoveEvent += OnMoveEvent;
            _inputReader.EvadeEvent += OnEvadeEvent;

        }
        private void OnDisable()
        {
            _inputReader.MoveEvent -= OnMoveEvent;
            _inputReader.EvadeEvent -= OnEvadeEvent;

        }

        private void Start()
        {
            _abilityRunner = GetComponent<AbilityRunner>();
            speedModifier = 1f;

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
            float targetSpeed = TargetSpeed * speedModifier;

            if (movementInput == Vector2.zero)
            {
                targetSpeed = 0;
            }

            var move = new Vector3(movementInput.x, movementInput.y, 0);

            movementBlend = Mathf.Lerp(movementBlend, targetSpeed, Time.deltaTime * 10f);
            movementVector = targetSpeed * Time.deltaTime * move;
        }

        private void OnMoveEvent(Vector2 move)
        {
            movementInput = move;
        }

        private void OnEvadeEvent(bool isEvading)
        {
            if (isEvading)
            {
                AbilityStatus status = _abilityRunner.GetAbility("Evade", out var ability);

                if (status == AbilityStatus.IsReady)
                {
                    ability.Run();
                }
                else if (status == AbilityStatus.IsOnCooldown)
                {
                    Debug.Log($"{ability.originSO.Name} is on cooldown");
                }
                else
                {
                    Debug.Log("Ability is not found");
                }
            }
        }
    }
}
