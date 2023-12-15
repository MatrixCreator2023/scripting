using UnityEngine;

public class SticksMovement : MonoBehaviour
{
    float speedRotation = 2.5f;
    
    void Update()
    {
        transform.Rotate(0, speedRotation, 0);
        
    }

   
}

