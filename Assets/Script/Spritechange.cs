using System.Collections.Generic; // needed for array lists
using UnityEngine;
using UnityEngine.InputSystem;

public class Spritechange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    //public Sprite[] barrels; array
    public List<Sprite> barrels; // array list
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickaRandomColour();
        PickARandomSprite();

    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite renderer");
            //    PickaRandomColour();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

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
        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickaRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
        //spriteRenderer.color = col;
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = ;

        // random number
        //randomNumber = Random.Range(0, 3);
        randomNumber = Random.Range(0, barrels.Count); //Length for arrays, Count for array list
        //use number to choose a sprite
        //assign that sprite to the sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
        //if (randomNumber == 0)
        //{
        //    spriteRenderer.sprite = Barrel0;
        //}
        //else if (randomNumber == 1)
        //{
        //    spriteRenderer.sprite = Barrel1;
        //}
        //else if (randomNumber == 2)
        //{
        //    spriteRenderer.sprite = Barrel2;
        //}

    }
}
