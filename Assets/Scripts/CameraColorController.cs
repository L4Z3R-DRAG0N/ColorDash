using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    private Camera this_camera;
    public Color original_color;
    public Color target_color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this_camera = GetComponent<Camera>();
        original_color = this_camera.backgroundColor;
    }

    private void Update()
    {
        this_camera.backgroundColor = Color.Lerp(this_camera.backgroundColor, target_color, Time.deltaTime * 2);
    }

    public void SetColor(Color color)
    {
        this_camera.backgroundColor = color / 340;
    }

    public void ResetColor()
    {
        target_color = original_color;
    }
}
