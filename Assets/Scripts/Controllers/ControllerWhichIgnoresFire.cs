using UnityEngine;

public class ControllerWhichIgnoresFire : Entity
 {
    public void Fire()
    {
        Debug.Log("I will never fire.");
    }
}