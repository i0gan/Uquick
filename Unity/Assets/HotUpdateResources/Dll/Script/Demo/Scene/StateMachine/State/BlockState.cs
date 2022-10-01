﻿using UnityEngine;
using System.Collections;
using SquickProtocol;
using Squick;

public class BlockState : IState
{
    public BlockState(GameObject gameObject, AnimaStateType eState, AnimaStateMachine xStateMachine, float fHeartBeatTime, float fExitTime, bool input = false)
        : base(gameObject, eState, xStateMachine, fHeartBeatTime, fExitTime, input)
    {

	}
	
}