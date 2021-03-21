using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Movement movement;
    public float mouseSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0, movement.getMouseX() * mouseSensitivity, 0);   
    }

}
