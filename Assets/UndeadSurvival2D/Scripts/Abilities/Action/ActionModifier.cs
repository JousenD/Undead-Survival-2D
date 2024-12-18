using JousenD.UndeadSurvival2d.Abilities.Scriptable;

namespace JousenD.UndeadSurvival2d.Abilities.Action
{
    public abstract class ActionModifier
    {
        public ActionModifierSO originSO;

        public abstract void Awake(AbilityAction action);
        public abstract void OnEnter(AbilityAction action);

        public abstract void Update(AbilityAction action);
    }
}

