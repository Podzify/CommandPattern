using UnityEngine;

public class UserInput : MonoBehaviour {

    public KeyCode forward = KeyCode.UpArrow;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode fire = KeyCode.Space;

    private ICommand fireCommand;
    private Entity entity;

    void Awake()
    {
        entity = GetComponent<Entity>();
        fireCommand = new FireCommand();
    }

    void Update () {
        if (Input.GetKeyDown (fire)) {
            fireCommand.Execute(entity);
        }
    }
}