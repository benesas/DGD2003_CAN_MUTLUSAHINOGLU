using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3.5f;

    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        agent.SetDestination(player.position);

        if (agent.velocity.magnitude > 0.1f)
            animator.SetBool("isRunning", true);
        else
            animator.SetBool("isRunning", false);
    }
}