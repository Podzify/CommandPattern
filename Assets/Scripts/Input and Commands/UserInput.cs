using UnityEngine;
    
public class UserInput : MonoBehaviour {
    
    public KeyCode forward = KeyCode.UpArrow;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode fire = KeyCode.Space;
    
    private ICommand fireCommand;
    
    void Awake()
    {
        IFire entity = GetComponent<IFire>();
        if (entity != null)
            fireCommand = new FireCommand(entity);
    }
    
    void Update () {
        if (Input.GetKeyDown (fire) && fireCommand != null) {
            
            fireCommand.Execute();
        }
    }
}

// Original suggestion on forum

// using UnityEngine;

// public class UserInput : MonoBehaviour
// {
//     public KeyCode forward = KeyCode.UpArrow;
//     public KeyCode left = KeyCode.LeftArrow;
//     public KeyCode right = KeyCode.RightArrow;
//     public KeyCode fire = KeyCode.Space;
    
//     private ICommand fireCommand;
    
//     void Awake()
//     {
//     IFire entity = GetComponent<IFire>();
//     fireCommand = new FireCommand(entity); // <-- receiver is passed in here
//     }
    
//     void Update ()
//     {
//     if (Input.GetKeyDown (fire))
//         fireCommand.Execute();
//     }
// }