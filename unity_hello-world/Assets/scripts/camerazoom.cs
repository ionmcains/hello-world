using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{

    public int zoomspeed2d;
    public int zoomspeed3d;
    public int maxval;
    public int minval;
    public int maxval3d;
    public int minval3d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographic)
        {
            if(Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Camera.main.orthographicSize -= zoomspeed2d * Time.deltaTime;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.orthographicSize += zoomspeed2d * Time.deltaTime;
            }
       

            Camera.main.orthographicSize =  Mathf.Clamp(Camera.main.orthographicSize, minval, maxval);
        }
        else
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Camera.main.fieldOfView -= zoomspeed3d * Time.deltaTime;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.fieldOfView += zoomspeed3d * Time.deltaTime;
            }
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minval3d, maxval3d);
        }
    }
}
