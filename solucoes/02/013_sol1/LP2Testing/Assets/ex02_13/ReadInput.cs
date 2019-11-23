using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    public Vector2 GetVector2()
    {
        return new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}
