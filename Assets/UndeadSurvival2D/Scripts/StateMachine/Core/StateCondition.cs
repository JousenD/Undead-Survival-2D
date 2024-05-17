using JousenD.UndeadSurvival2d.StateMachine.Scriptable;

namespace JousenD.UndeadSurvival2d.StateMachine
{
    public abstract class StateCondition : IStateComponent
    {
        public StateConditionSO originSO;

        public bool IsMet()
        {
            var statement = Statement();
            return statement;
        }

        protected abstract bool Statement();

        public abstract void Awake(StateMachineCore stateMachine);
        public abstract void OnEnter();
        public abstract void OnExit();
    }
}
