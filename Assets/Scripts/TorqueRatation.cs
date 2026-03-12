using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRatation : MonoBehaviour
{
    [SerializeField] float torqueSpeed;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddTorque(Vector3.up * torqueSpeed * Time.deltaTime);
        }
        //else
        //{
        //    rb.angularVelocity = Vector3.zero;
        //}

    }
}
