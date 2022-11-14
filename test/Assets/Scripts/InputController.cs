using System;
using UnityEngine;

public class InputController : MonoBehaviour
{ 
    public event Action onLeftClick;
    public event Action onRightClick;
    public event Action onJumpClick;
    public event Action onStopMove;


    private void Update() 
    { 
        if (Input.GetKey(KeyCode.A))
        {
            onLeftClick?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            onStopMove?.Invoke();
        }
        if (Input.GetKey(KeyCode.D))
        {
            onRightClick?.Invoke(); 
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            onStopMove?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
           onJumpClick?.Invoke();
        }
    }
}