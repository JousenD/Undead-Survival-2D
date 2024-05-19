using UnityEngine;

namespace JousenD.UndeadSurvival2d.Reward.Scriptable
{
    [CreateAssetMenu(
        fileName = "ExperienceSO",
        menuName = "Rewards/Experience Rewards"
    )]
    public class ExperienceRewardSO : RewardSO
    {
        public int experience;
    }
}