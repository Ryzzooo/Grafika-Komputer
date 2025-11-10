using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 movement;
    Rigidbody rb;
    [SerializeField] private float speed = 50f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * speed, ForceMode.Acceleration);
    }

    void Walk()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }
}
