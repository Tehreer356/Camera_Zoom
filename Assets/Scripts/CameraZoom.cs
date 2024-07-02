using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public int zoomSpeed2D;
    public int zoomSpeed3D;
    public float minZoom, maxZoom;
    public float minZoom3D, maxZoom3D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographic)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
        }
        else 
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);
        }
    }
}
