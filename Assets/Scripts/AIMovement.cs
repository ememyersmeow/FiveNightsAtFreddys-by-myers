using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public Animator anim;

    private void Start()
    {

        agent.destination = target.position;
    }
    void Update()
    {
        anim.SetBool("isWalk", true);
    }

}
