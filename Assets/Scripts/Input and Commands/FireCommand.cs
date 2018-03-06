using UnityEngine;

public class FireCommand : ICommand {

	public void Execute(Entity entity)
	{
		Debug.Log("Fire Command executing on Entity: " + entity);
		if (entity is IFire)
		{
			((IFire)entity).Fire();
		}
	}
}