using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 400f;
    [SerializeField]float moveSpeed = 20f; //.05

    void Update()
    {
        float move = 0f;
        float steer = 0f;
        
        if(Keyboard.current.wKey.isPressed) //upArrowKey
        {
            move = 1f;
        }

        else if(Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if(Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        else if(Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
        float moveAmount = moveSpeed * move * Time.deltaTime;
        float steerAmount = steerSpeed * steer * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
