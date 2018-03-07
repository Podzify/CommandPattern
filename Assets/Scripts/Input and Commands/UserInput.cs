using UnityEngine;
    
public class UserInput : MonoBehaviour
{
    public KeyCode forward = KeyCode.UpArrow;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode fire = KeyCode.Space;
    
    private ICommand fireCommand;
    
    void Awake()
    {
    var entity = GetComponent<IFire>() ?? new NoFire(); // <-- entity will never be null
    fireCommand = new FireCommand(entity);
    }
    
    void Update ()
    {
    if (Input.GetKeyDown (fire))
        fireCommand.Execute();
    }
}