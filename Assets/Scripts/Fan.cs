using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField]private float fanSpeed = 500f;

    private void Update()
    {
        transform.Rotate(0, 0, fanSpeed * Time.deltaTime);
    }
}
