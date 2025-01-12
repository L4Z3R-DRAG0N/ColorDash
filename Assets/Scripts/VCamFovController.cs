using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VCamFovController : MonoBehaviour
{
    private CinemachineCamera vcam;
    private float target_fov;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vcam = GetComponent<CinemachineCamera>();
        target_fov = vcam.Lens.FieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        vcam.Lens.FieldOfView = Mathf.Lerp(vcam.Lens.FieldOfView, target_fov, Time.deltaTime * 2);
    }

    public void SetFOV(float fov)
    {
        target_fov = fov;
    }

    public void ResetFOV()
    {
        SetFOV(60);
    }
}
