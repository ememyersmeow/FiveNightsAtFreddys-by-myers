using System.Collections;
using UnityEngine;

public class PhoneSound : MonoBehaviour
{
    public AudioSource mySource;
    public GameObject button;

    private void Start()
    {
        button.SetActive(false);
        StartCoroutine(PhoneTimer());
    }

    public void PhoneClick()
    {
        mySource.Stop();
        button.SetActive(false);
    }

    IEnumerator PhoneTimer()
    {
        yield return new WaitForSeconds(5);
        button.SetActive(true); 
    }
}
