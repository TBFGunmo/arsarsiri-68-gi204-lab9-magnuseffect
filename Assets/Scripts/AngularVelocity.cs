using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    [SerializeField] float angularVelocitySpeed;
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
            rb.angularVelocity = new Vector3(0, angularVelocitySpeed, 0);
        }
        else 
        {
            rb.angularVelocity = Vector3.zero;
        }

    }

}
