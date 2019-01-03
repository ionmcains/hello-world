using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewithmouse : MonoBehaviour
{

    public float rotationspeed;

    private void OnMouseDrag()
    {
        float Y = Input.GetAxis("Mouse Y") * rotationspeed;
        transform.Rotate(Vector3.right, Y);
        float X = Input.GetAxis("Mouse X") * rotationspeed;
        transform.Rotate(Vector3.up, -X);
    }
}
