using UnityEngine;

public class BlockBoost : MonoBehaviour
{
    private float original_speed;
    private VCamFovController vcam_fov_controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        original_speed = 1;
        vcam_fov_controller = GameObject.Find("CM vcam1").GetComponent<VCamFovController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<PlayerController>().velocity += new Vector3(0, 0, 3);
        Camera.main.GetComponent<CameraColorController>().SetColor(new Color(0, 255, 35));
        vcam_fov_controller.SetFOV(72);
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<PlayerController>().velocity = new Vector3(0, 0, 10);
        Camera.main.GetComponent<CameraColorController>().ResetColor();
        vcam_fov_controller.ResetFOV();
    }
}
