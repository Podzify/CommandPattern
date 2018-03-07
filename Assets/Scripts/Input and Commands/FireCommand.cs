using System;
using UnityEngine;

public class FireCommand : ICommand
{
	private IFire FiringEntity { get; set; }
	
	public FireCommand(IFire firingEntity) // <-- inject a strongly typed reference to the receiver
	{
		if (firingEntity == null)
 			// throw new ArgumentNullException($"{nameof(firingEntity)} cannot be null"); // Guard clause (in C# 6.0)
			throw new ArgumentNullException("Firing Entity cannot be null"); // Guard clause (in C# 6.0)
 
		FiringEntity = firingEntity;
	}
	
	public void Execute()
	{
		// Debug.Log(entity.gameObject.name + "(" + entity.GetType() + ") fired.");
		FiringEntity.Fire();
	}
}
