using System.Collections;
using UnityEngine;

public class Tablet : MonoBehaviour
{
    public GameObject minimap;
    public GameObject[] cameras;
    public GameObject mainCamera;
    public Animator anim;
    private int currentCameraIndex = 0;
    public Battery energy;

    private void Update()
    {
        if(energy.energy <= 0)
        {
            Close();
        }
    }

    public void tabChangeVisible()
    {
        if(minimap.activeSelf || energy.energy <= 0)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

     void Open()
     {
        anim.SetBool("isTablet", true);
        StartCoroutine(Delay());
     }

    public void Close()
    {
        anim.SetBool("isTablet", false);
        cameras[currentCameraIndex].SetActive(false);
        mainCamera.SetActive(true);
        minimap.SetActive(false);
    }

    public void ChangeCamera(int index)
    {
        cameras[currentCameraIndex].SetActive(false);
        currentCameraIndex = index;
        cameras[currentCameraIndex].SetActive(true);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.3f);
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        cameras[currentCameraIndex].SetActive(true);
    }
}
