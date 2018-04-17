﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurdererAnimCtrl : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject Murderer = animator.gameObject;

        if (stateInfo.IsName("AttackW"))
        {
            Murderer.GetComponent<MurdererCtrl>().SetState(0);
        }
        else if (stateInfo.IsName("AttackL"))
        {
            Murderer.GetComponent<MurdererCtrl>().SetState(0);
        }
        else if (stateInfo.IsName("Parry"))
        {
            Murderer.GetComponent<MurdererCtrl>().SetState(0);
        }
    }
}
