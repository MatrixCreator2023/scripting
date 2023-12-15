using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.5f;
    Vector3 newXPosition;
    void Update()
    {
        newXPosition.x = transform.position.x + speed * Time.deltaTime;
        transform.position = newXPosition;
    }
}
