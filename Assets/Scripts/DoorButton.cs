using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public GameObject door;
    private Vector3 startPos;
    private Vector3 endPos;
    public int speed;
    public bool IsClose;
    public Battery energy;

    private void Update()
    {
        if(energy.energy <= 0)
        {
            Destroy(door);
        }
    }

    void Start()
    {
        IsClose = false;
        startPos = door.transform.position;
        endPos = new Vector3(startPos.x, startPos.y - 7f, startPos.z);

    }
    void FixedUpdate()
    {
        if (IsClose == true) door.transform.position = Vector3.MoveTowards(door.transform.position, endPos, speed * Time.deltaTime);
        if (IsClose == false) door.transform.position = Vector3.MoveTowards(door.transform.position, startPos, speed * Time.deltaTime);
    }
    void OnMouseDown()
    {
        if (IsClose)
        {
            IsClose = false;
        }
        else
        {
            IsClose = true;
        }
    }

}