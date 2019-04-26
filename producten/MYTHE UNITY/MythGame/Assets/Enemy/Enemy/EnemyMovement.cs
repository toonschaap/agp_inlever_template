using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Animator _animator;
    private NavMeshAgent _nav;
    private Rigidbody rigidbody;
    private Transform _player;

    //Na play testing hebben we dit gehard coded omdat het de beste tempo was.
    private float speed = 2f;
    private bool moveTo = false;

    [SerializeField]
    private Transform PlayerTransform;

    //At what distance will the enemy walk towards the player?
    [SerializeField]
    private float walkingDistance = 10.0f;

    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _nav = GetComponent<NavMeshAgent>();
        rigidbody = GetComponent<Rigidbody>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        //The enemy calculates the distance between him and the player, but remains idle
        float distance = float.MaxValue;
        if (moveTo == false)
        {
            distance = Vector3.Distance(transform.position, PlayerTransform.position);
            //When the enemy sees the player
        }
        else
        {
            _nav.SetDestination(_player.position);
        }
        //When the enemy sees the player for the first time
        if (distance < walkingDistance && moveTo == false)
        {
            bool run = _nav.velocity != Vector3.zero;
            moveTo = true;

            run = run && !_animator.GetBool("attackRange");

            _animator.SetBool("run", true);
        }
    }
}