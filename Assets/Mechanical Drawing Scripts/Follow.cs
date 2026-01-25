using UnityEngine;
using UnityEngine.InputSystem;

public class Follow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Determines the mouse position on the screen and translates the values to meters
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Object follows the mouse
        transform.position = mousePos;

        //code from the mouse Pos example from class

    }
}
