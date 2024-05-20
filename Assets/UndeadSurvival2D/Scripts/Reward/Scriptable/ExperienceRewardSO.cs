using UnityEngine;
using JousenD.UndeadSurvival2d.Player;

namespace JousenD.UndeadSurvival2d.Reward.Scriptable
{
    [CreateAssetMenu(
        fileName = "ExperienceSO",
        menuName = "Rewards/Experience Rewards"
    )]
    public class ExperienceRewardSO : RewardSO
    {
        public int experience;

        public override void Apply(PlayerBehaviour player)
        {
            player.SetExperience(experience);
        }
    }
}