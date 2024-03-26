using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float sensitivy = 150f;
    [SerializeField] private float rotateZone = Screen.width / 5;
    public GameObject screamer;
    public GameObject playerCamera;

    private void Update()
    {
        if(playerCamera.activeSelf == true && screamer.activeSelf == false)
        {
            MouseMove();
        }

        if(screamer.activeSelf == true)
        {
            transform.localEulerAngles = new Vector3 (0, -270, 0);
        }
    }

    private void MouseMove()
    {
        if (Input.mousePosition.x < rotateZone && transform.rotation.eulerAngles.y > 20)
        {
            transform.Rotate(0, -sensitivy * Time.deltaTime, 0);
        }

        if (Input.mousePosition.x > Screen.width - rotateZone && transform.rotation.eulerAngles.y < 160)
        {
            transform.Rotate(0, sensitivy * Time.deltaTime, 0);
        }
    }
}
