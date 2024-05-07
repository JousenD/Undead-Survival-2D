
using UnityEngine;

namespace JousenD.UndeadSurvival2d.Abilities.Scriptable
{
    public abstract class AbilitySO : ScriptableObject
    {
        public string Name;

        public virtual Ability GetAbility(MonoBehaviour runner)
        {
            var ability = CreateAbility();
            ability.Awake(runner);
            return ability;
        }

        protected abstract Ability CreateAbility();
    }
}
