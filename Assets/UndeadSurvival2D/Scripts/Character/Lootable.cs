using JousenD.UndeadSurvival2d.Reward;
using TMPro;
using UnityEngine;

namespace JousenD.UndeadSurvival2d.Character
{
    public class Lootable : MonoBehaviour
    {
        public Loot Loot;

        public void DropLoot()
        {
            var roll = Random.Range(0f, 100f);

            if (roll <= Loot.dropChance)
            {
                var boolLoot = roll <= Loot.dropChance;
                Loot.reward.Drop(this);
            }
        }

        // private void Start() {
        //     DropLoot();    
        // }
    }
}