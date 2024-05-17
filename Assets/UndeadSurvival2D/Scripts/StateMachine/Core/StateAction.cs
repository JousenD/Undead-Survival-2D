using JousenD.UndeadSurvival2d.StateMachine.Scriptable;

namespace JousenD.UndeadSurvival2d.StateMachine
{
    abstract public class StateAction : IStateComponent
    {
        public StateActionSO originSO;
        public virtual void Awake(StateMachineCore stateMachine) { }

        public virtual void OnEnter() { }
        public virtual void OnExit() { }
        public virtual void OnUpdate() { }
    }
}