using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mousemovement : MonoBehaviour
{
    float mouseX = 0;
    float mouseY = 0;

    void Update()
    {
        int rvalue = Random.Range(1,3);

        this.gameObject.transform.position = Input.mousePosition;

        if (Input.mousePosition.x <= Random.Range(10,15))
        {
            mouseX += rvalue;
        }
        if (Input.mousePosition.y <= Random.Range(10,15))
        {
            mouseY += rvalue;
        }
        if (Input.mousePosition.x >= Random.Range(5, 10))
        {
            mouseX -=rvalue;
        }
        if (Input.mousePosition.y >= Random.Range(5, 10))
        {
            mouseY -= rvalue;
        }

        if (Input.GetKey("w"))
        {
            WarpCursorPosition();
        }

        Debug.Log(Input.mousePosition);
    }

    public void PosToWarp()
    {
        
    }
    public void WarpCursorPosition()
    {
        Mouse.current.WarpCursorPosition(new Vector2(Mathf.Lerp(Input.mousePosition.x, mouseX, 10 * Time.deltaTime), Mathf.Lerp(Input.mousePosition.y, mouseY, 10 * Time.deltaTime)));
    }
}
