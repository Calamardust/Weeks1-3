using UnityEngine;

public float t;

public class Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()



    {
        t += Time.deltaTime;

        if (t >= 3)
        {
            t = 0;
            Transform.position = Vector2(Random(0, Screen.width), Random(0, Screen.height);
        }
    }

    
        
}
