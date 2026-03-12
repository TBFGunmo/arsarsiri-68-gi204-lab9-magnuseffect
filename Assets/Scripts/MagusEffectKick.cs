using UnityEngine;
using UnityEngine.InputSystem;

public class MagusEffectKick : MonoBehaviour
{

    [SerializeField] float kickForce;
    [SerializeField] float spinAmount;
    [SerializeField] float magnusStrength = 0.5f;

    Rigidbody rb;
    bool isKick = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isKick) 
        {
            rb.AddForce(transform.forward * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spinAmount);

            isKick = true;

        }
    }

    private void FixedUpdate()
    {
        if (!isKick) 
        {
            return;
        }

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = magnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(magnusForce);
    }

}
