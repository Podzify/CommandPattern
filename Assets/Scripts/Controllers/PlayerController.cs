using UnityEngine;

public class PlayerController : Entity, IFire
 {
    public void Fire()
    {
        Debug.Log("PlayerController " + gameObject.name + ": I am firing.");
    }
}