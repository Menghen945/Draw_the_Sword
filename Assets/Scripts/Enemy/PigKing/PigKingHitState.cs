using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigKingHitState : EnemyState
{
    private PigKing enemy;
    public PigKingHitState(Enemy _enemybase, EnemyStateMachine _stateMachine, string _anim, PigKing _enemy) : base(_enemybase, _stateMachine, _anim)
    {
        enemy = _enemy;
    }

    public override void Start()
    {
        base.Start();
        enemy.fx.InvokeRepeating("RedColorBlink", 0, .1f);
        stateTimer = enemy.hitDuration;
    }

    public override void Exit()
    {
        base.Exit();
        enemy.fx.CancelColorChange();
    }

    public override void Update()
    {
        base.Update();
        if(stateTimer <= 0)
            stateMachine.ChangeState(enemy.idleState);
    }
}
