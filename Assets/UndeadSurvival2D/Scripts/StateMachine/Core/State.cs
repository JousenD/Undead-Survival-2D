using JousenD.UndeadSurvival2d.StateMachine.Scriptable;
using UnityEngine;

namespace JousenD.UndeadSurvival2d.StateMachine
{
    public class State
    {
        public StateSO originSO;
        public StateAction[] actions;
        public string Name => originSO.Name;

        public void OnEnter()
        {
            Debug.Log(Name + " was Entered");
        }

        public void OnExit()
        {
        }

        public void OnUpdate()
        {
            for (var i = 0; i < actions.Length; i++)
            {
                actions[i].OnUpdate();
            }
        }

    }

}