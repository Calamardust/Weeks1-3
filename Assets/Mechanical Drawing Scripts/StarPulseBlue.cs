using System.Security.Cryptography;
using UnityEngine;

public class StarPulseBlue : MonoBehaviour
{
    //Public AnimationCurve to show and modify in inspector
    public AnimationCurve curve;
    //Public value for Time
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // using delta time to establish the time value in seconds
        t += Time.deltaTime;

        // 2 second period instead of 1 for the animation
        // The time value in the Curve is set to 1.5 instead of 2 to make the star disapear for a moment
        if (t > 2)
        {
            // resets timer t
            t = 0;
        }
        //Float affected by the Animation Curve
        float y = curve.Evaluate(t);
        //Constanly changes the scale of the obeject based on the Animation Curve
        transform.localScale = Vector3.one * y;

        //code based on the pulse example from class
    }
}
