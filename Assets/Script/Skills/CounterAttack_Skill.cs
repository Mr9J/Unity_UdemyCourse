using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAttack_Skill : Skill
{
    public override void UseSkill()
    {
        base.UseSkill();

        Debug.Log("CounterAttack!");
    }
}
