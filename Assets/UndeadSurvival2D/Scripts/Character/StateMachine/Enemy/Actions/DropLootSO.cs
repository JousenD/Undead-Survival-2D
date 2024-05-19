using System;
using UnityEngine;
using JousenD.UndeadSurvival2d.StateMachine;
using JousenD.UndeadSurvival2d.StateMachine.Scriptable;
using JousenD.UndeadSurvival2d.Character;

[CreateAssetMenu(
    fileName = "DropLootSO",
    menuName = "StateMachine/Enemy/Actions/Drop Loot"
)]
public class DropLootSO : StateActionSO
{
    public override StateAction CreateAction()
    {
        return new DropLootAction();
    }
}

public class DropLootAction : StateAction
{
    private Lootable _lootable;

    public override void Awake(StateMachineCore stateMachine)
    {
        _lootable = stateMachine.GetComponent<Lootable>();
    }

    public override void OnEnter()
    {
        _lootable.DropLoot();
    }
}