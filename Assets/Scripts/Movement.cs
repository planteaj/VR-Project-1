using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool Down = false;
    private bool Up = false;
    private bool Left = false;
    private bool Right = false;
    private float MouseX = 0.0f;
    private float MouseY = 0.0f;
    private bool Space = false;

    private bool Escape = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool getDown()
    {
        return Down;
    }

    public bool getLeft()
    {
        return Left;
    }

    public bool getRight()
    {
        return Right;
    }

    public bool getUp()
    {
        return Up;
    }
    public bool getSpace()
    {
        return Space;
    }

     public float getMouseX()
    {
        return MouseX;
    }

     public float getMouseY()
    {
        return MouseY;
    }

    public bool getEscape() {
       return Escape;
    }

    // Update is called once per frame
    void Update()
    {
       MouseX = Input.GetAxis("Mouse X");
       MouseY = Input.GetAxis("Mouse Y");

      if(Input.GetKey(KeyCode.S))
         Down=true;
      else Down = false;
      if(Input.GetKey(KeyCode.A))
         Left=true;
      else Left = false;
      if(Input.GetKey(KeyCode.D))
         Right=true;
      else Right = false;
      if(Input.GetKey(KeyCode.W))
         Up=true;
      else Up = false;
      if(Input.GetKey(KeyCode.Space))
         Space=true;
      else Space = false;
       if(Input.GetKeyDown(KeyCode.Escape))
         Escape=true;
      else Escape = false;
/*
        if(Input.GetKeyDown(KeyCode.S))
           Down = true;
        if(Input.GetKeyUp(KeyCode.S))
           Down = false;
        if(Input.GetKeyDown(KeyCode.A))
           Left = true;
        if(Input.GetKeyUp(KeyCode.A))
           Left = false;
        if(Input.GetKeyDown(KeyCode.D))
           Right = true;
        if(Input.GetKeyUp(KeyCode.D))
           Right = false;
        if(Input.GetKeyDown(KeyCode.W))
           Up = true;
        if(Input.GetKeyUp(KeyCode.W))
           Up = false;
        if(Input.GetKeyDown(KeyCode.Space))
           Space = true;
        if(Input.GetKeyUp(KeyCode.Space))
           Space = false;
           */
    }
}
