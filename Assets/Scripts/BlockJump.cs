using UnityEngine;

public class BlockJump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerController>().velocity.y = 20;
        Camera.main.GetComponent<CameraColorController>().SetColor(new Color(0, 169, 255));
    }

    private void OnTriggerExit(Collider other)
    {
        Camera.main.GetComponent<CameraColorController>().ResetColor();
    }
}
