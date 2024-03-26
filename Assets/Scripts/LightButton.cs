using UnityEngine;

public class LightButton : MonoBehaviour
{
    [SerializeField] private GameObject dark;
    [SerializeField] private GameObject light;
    public Battery energy;

    private void Start()
    {
        dark.SetActive(false);
        light.SetActive(false);
    }

    private void Update()
    {
        if(energy.energy <= 0)
        {
            light.SetActive(false);
            dark.SetActive(false);
        }
    }

    private void OnMouseDrag()
    {
        dark.SetActive(false);
        light.SetActive(true);
    }

    private void FixedUpdate()
    {
        dark.SetActive(true);
        light.SetActive(false);
    }
}
