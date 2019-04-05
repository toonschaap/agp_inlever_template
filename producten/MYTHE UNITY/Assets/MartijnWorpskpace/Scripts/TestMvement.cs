using UnityEngine;

public class TestMvement : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    private float speed = 20.0f;

    // Update is called once per frame
    private void Update()
    {
        WalkFunction();
    }

    private void WalkFunction()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection *= speed;
        moveDirection *= Time.deltaTime;

        Vector3 moveDirection2 = new Vector3(0, 0, Input.GetAxis("Vertical"));
        moveDirection2 *= speed;
        moveDirection2 *= Time.deltaTime;

        transform.Translate(moveDirection);
        transform.Translate(moveDirection2);

        Vector3 pos = transform.position;
        //pos.x = Mathf.Clamp(pos.x, -25, 25);
        //pos.z = Mathf.Clamp(pos.z, -25, 25);
        transform.position = pos;
    }
}