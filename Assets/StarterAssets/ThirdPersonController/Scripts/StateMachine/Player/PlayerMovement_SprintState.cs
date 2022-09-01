using StarterAssets;
using UnityEngine;

public class PlayerMovement_SprintState : PlayerMovementBase
{
	public override void OnEnter()
	{
		Debug.Log("Sprint");
		Player.targetSpeed = Player.SprintSpeed;
	}

	public override void OnUpdate()
	{
		Player.Move();
		
		if(!Input.sprint)
			Player.SwitchToState(InputState.WalkState);
	}

	public override void OnExit()
	{
		
	}
}
