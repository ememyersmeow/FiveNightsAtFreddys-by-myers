using UnityEngine;

public class MainLight : MonoBehaviour
{
    [SerializeField] private GameObject mainLight;
    [SerializeField] private GameObject light2;
    [SerializeField] private GameObject light3;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [SerializeField] private Battery energy;
    [SerializeField] private GameObject cameraButton;

    private void Update()
    {
        if(energy.energy <= 0)
        {
            mainLight.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            cameraButton.SetActive(false);
        }
    }
}
