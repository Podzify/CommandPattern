using UnityEngine;

public class FireCommand : ICommand
{
	private IFire FiringEntity { get; set; }
	
	public FireCommand(IFire firingEntity) // <-- inject a strongly typed reference to the receiver
	{
	FiringEntity = firingEntity;
	}
	
	public void Execute()
	{
	// Debug.Log(entity.gameObject.name + "(" + entity.GetType() + ") fired.");
	FiringEntity.Fire();
	}
}
