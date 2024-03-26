using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    private int time = 0;
    private Text clock;

    private void Awake()
    {
        clock = GetComponent<Text>();
        InvokeRepeating("Timer", 60f, 60f);
    }

    public void Timer()
    {
        time++;
        clock.text = time.ToString() + "AM";
        if(time == 6)
        {
            CancelInvoke();
            SceneManager.LoadScene(3);
        }
    }
}
