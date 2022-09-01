using StarterAssets;
using UnityEngine;

public class PlayerMovement_WalkState : PlayerMovementBase
{
	public override void OnEnter()
	{
		Debug.Log("Walk");
		Player.targetSpeed = Player.MoveSpeed;
	}

	public override void OnUpdate()
	{
		if (!Player.IsMoving())
		{
			Player.SwitchToState(InputState.IdleState);
			return;
		}
		
		Player.Move();
		
		// set target speed based on move speed, sprint speed and if sprint is pressed
		if (Input.sprint)
			Player.SwitchToState(InputState.SprintState);
	}

	public override void OnExit()
	{
		
	}
}
