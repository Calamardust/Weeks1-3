using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class LerpBlackHole : MonoBehaviour
{
    // Public values for the start and end of the animation
    public Transform start;
    public Transform end;

    // Public time value and Animation Curve
    public float t;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // using delta time to establish the time value in seconds
        t += Time.deltaTime;
        // 3 second period instead of 1 for the animation
        if (t > 3)
        {
            // resets timer t
            t = 0;
        }

        // Adds linear interpolation between 2 points, movement velocity and acceleration is based on an Animation curve
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        //code based on the linear interpolation example from class
    }
}
