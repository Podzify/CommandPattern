using UnityEngine;

public class UFOController : Entity, IFire
 {
    public void Fire()
    {
        Debug.Log("UFOController " + gameObject.name + ": I am firing completely differently.");
    }
}