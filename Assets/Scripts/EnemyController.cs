using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform checkPoint;
    public Animator anim;
    public int toPlayerChance;
    public AudioSource animatronicStep;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = agent.GetComponent<Animator>();
        Invoke("Move", 60f);
    }

    private void Move()
    {
        NextPoints point = checkPoint.GetComponent<NextPoints>();
        checkPoint = point.getNext();
        agent.destination = checkPoint.position;
        Invoke("Move", 25f);
    }

    private void Update()
    {
        if(agent.velocity.x != 0 | agent.velocity.z != 0)
        {
            animatronicStep.volume = Mathf.Lerp(animatronicStep.volume, 0.8f, 2 * Time.deltaTime);
            anim.SetBool("isWalk", true);
        }
        else
        {
            animatronicStep.volume = Mathf.Lerp(animatronicStep.volume, 0, 4 * Time.deltaTime);
            anim.SetBool("isWalk", false);
        }
    }
}
