using StarterAssets;

public class PlayerMovementBase
{
	protected static PlayerController Player;

	protected static StarterAssetsInputs Input;
	
	protected PlayerMovementBase() { }

	public PlayerMovementBase(PlayerController player, StarterAssetsInputs input)
	{
		Player = player;
		Input = input;
	}
	
	public virtual void OnEnter() { }

	public virtual void OnUpdate() { }
	
	public virtual void OnExit() { }
}
