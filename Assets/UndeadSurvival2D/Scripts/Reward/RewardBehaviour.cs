using UnityEngine;
using System;
using JousenD.UndeadSurvival2d.Manager;
using JousenD.UndeadSurvival2d.Reward.Scriptable;


namespace JousenD.UndeadSurvival2d.Reward
{
    [Serializable]
        public struct Loot
        {
        public RewardSO reward;
        public float dropChance;
        }
    public class RewardBehaviour : MonoBehaviour
    {
        public LayerMask InteractWith;
        public bool isTargeted;


        private void Update()
        {
            if (isTargeted)
            {
                var playerPosition = GameManager.Instance.GetPlayerPosition();

                transform.position = Vector3.MoveTowards(
                    transform.position,
                    playerPosition,
                    Time.deltaTime * 2.3f
                );
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if ((InteractWith.value & 1 << collision.gameObject.layer) > 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
