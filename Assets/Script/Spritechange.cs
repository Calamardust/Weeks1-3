using UnityEngine;
using UnityEngine.InputSystem;

public class Spritechange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickaRandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    PickaRandomColour();
        //}

        // get mouse pos
     Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // is the mouse over shape ?
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
      
        // y = change col variable

    }

    void PickaRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
        //spriteRenderer.color = col;
    }
}
