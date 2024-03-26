using UnityEngine;

public class NouseSound : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip myClip;
    public GameObject mouse;

    private void OnMouseDown()
    {
        mySource.PlayOneShot(myClip);
    }
}
