using UnityEngine;

public class TransformObject : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.rotation = target.rotation;
    }
}
