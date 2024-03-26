using UnityEngine;

public class Battery : MonoBehaviour
{
    public float energy = 100;
    public float discharge = 0.2f;

    public GameObject[] segments;
    public Tablet tablet;
    public DoorButton door1;
    public DoorButton door2;
    public LightButton light1;
    public LightButton light2;

    private void Awake()
    {
        InvokeRepeating("Discharging", 1f, 1f);
    }

    private void Update()
    {
        SetDischarge();
        ViewEnergy();
    }

    private void Discharging()
    {
        energy -= discharge;
    }

    private void ViewEnergy()
    {
        if (energy < 66)
        {
            segments[2].SetActive(false);
        }
        if (energy < 33)
        {
            segments[1].SetActive(false);
        }
        if (energy < 0)
        {
            segments[0].SetActive(false);
        }
    }

    private void SetDischarge()
    {
        float tabletDC;
        float doorDC;
        float lightDC;

        //tablet
        if (tablet.minimap.activeSelf)
        {
            tabletDC = 0.1f;
        }
        else
        {
            tabletDC = 0;
        }

        //doors
        if(door1.IsClose == false && door2.IsClose == false)
        {
            doorDC = 0.2f;
        }
        else if(door1.IsClose == true && door2.IsClose == false)
        {
            doorDC = 0.5f;
        }
        else if (door1.IsClose == true && door2.IsClose == true)
        {
            doorDC = 1.5f;
        }
        else if (door1.IsClose == false && door2.IsClose == true)
        {
            doorDC = 0.5f;
        }
        else
        {
            doorDC = 0;
        }

        //light
        if(light1.isActiveAndEnabled == true || light2.isActiveAndEnabled == true)
        {
            lightDC = 0.1f;
        }
        else
        {
            lightDC = 0;
        }

        discharge = 0.1f + tabletDC + doorDC + lightDC;
    }
}
