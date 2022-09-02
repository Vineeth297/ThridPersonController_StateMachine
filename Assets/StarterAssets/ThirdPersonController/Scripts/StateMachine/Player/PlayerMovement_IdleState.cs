using StarterAssets;
using UnityEngine;

public class PlayerMovement_IdleState : PlayerMovementBase
{
	public override void OnEnter()
	{
		Player.targetSpeed = 0.0f;
	}

	public override void OnUpdate()
	{
		Player.UpdateAnim();


		if (Player.IsMoving())
		{
			Player.SwitchToState(InputState.WalkState);
		}
	}

	//if player on ground => move
	public override void OnExit()
	{
		
	}
}
