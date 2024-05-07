using UnityEngine;
using JousenD.UndeadSurvival2d.Abilities;
using JousenD.UndeadSurvival2d.Abilities.Scriptable;

[CreateAssetMenu(
    fileName = "MeleeAttackSO",
    menuName = "Abilities/MeleeAttack"
)]
public class MeleeAttackSO : AbilitySO
{
    protected override Ability CreateAbility()
    {
        return new MeleeAttack();
    }
}

public class MeleeAttack : Ability
{
    public override void Awake(MonoBehaviour runner)
    {
        base.Awake(runner);
    }

    public override void TriggerAbility()
    {
    }

    public override void Run()
    {
        base.Run();
    }
}
