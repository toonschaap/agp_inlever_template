using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    private bool runInput;
    private bool jumpInput;

    private float delta;
    private StateManager states;
    private CameraManager camManager;

    private void Start()
    {
        //init stateManeger and camManager
        states = GetComponent<StateManager>();
        states.Init();

        camManager = CameraManager.singleton;
        camManager.Init(this.transform);
    }

    private void FixedUpdate()
    {
        delta = Time.fixedDeltaTime;
        GetInput();
        UpdateStates();
        states.FixedTick(Time.deltaTime);
        camManager.Tick(delta);
    }

    private void Update()
    {
        //delta time
        delta = Time.deltaTime;
        states.Tick(delta);
    }

    private void GetInput()
    {
        //inputs
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        runInput = Input.GetButton("RunInput");
    }

    private void UpdateStates()
    {
        //alle states
        states.vertical = vertical;
        states.horizontal = horizontal;

        Vector3 v = states.vertical * camManager.transform.forward;
        Vector3 h = horizontal * camManager.transform.right;
        states.moveDir = (v + h).normalized;
        float m = Mathf.Abs(horizontal) + Mathf.Abs(vertical);
        states.moveAmount = Mathf.Clamp01(m);

        if (runInput)
        {
            states.run = (states.moveAmount > 0);
        }
        else
        {
            states.run = false;
        }
    }
}