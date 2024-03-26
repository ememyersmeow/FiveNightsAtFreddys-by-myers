using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitMenu : MonoBehaviour
{
    public AudioClip myClip;
    public AudioSource mySource;

    public void Start()
    {
        mySource.PlayOneShot(myClip);
        StartCoroutine(LoadNewScene());
    }

    IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(0);
    }
}
