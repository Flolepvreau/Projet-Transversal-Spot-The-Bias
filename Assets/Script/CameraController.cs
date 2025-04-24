using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private float zoom;
    public float zoomMultiplier;
    public float minZoom;
    public float maxZoom;
    private float velocity;
    public float smoothTime;

    [SerializeField] private Camera _camera;

    void Start()
    {
        zoom = _camera.orthographicSize;
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        _camera.orthographicSize = Mathf.SmoothDamp(_camera.orthographicSize, zoom, ref velocity, smoothTime);
        
    }
}
