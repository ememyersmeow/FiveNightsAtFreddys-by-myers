using UnityEngine;
using UnityEngine.SceneManagement;

public class Screamer : MonoBehaviour
{
    public GameObject screamer;
    public GameObject tab;
    public GameObject UI;
    Tablet cameras;
    Animator anim;
    public AudioSource mySource;
    public AudioClip myClip;

    private void Awake()
    {
        anim = screamer.GetComponent<Animator>();
        cameras = UI.GetComponent<Tablet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);
        if(other.tag == "Player")
        {
            cameras.Close();
            Destroy(tab);
            Destroy(UI);
            gameObject.SetActive(false);
            screamer.SetActive(true);
            mySource.PlayOneShot(myClip);
            anim.SetBool("Scream", true);
            Invoke("End", 2f);
        }
    }

    public void End()
    {
        SceneManager.LoadScene(1);
    }
}
