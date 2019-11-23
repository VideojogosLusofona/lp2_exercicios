using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ReadInput
{
    public static Vector2 GetMovement()
    {
        return new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}
