
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveDirection;
    public float horizontalInput;
    public float verticalInput;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void MovePlayer()
    {
        moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        rb.AddForce(moveDirection * moveSpeed * 10f, ForceMode.Force);
    }

    void GetInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hi");
            other.SendMessageUpwards("minigameLoad", 1);
        }
    }
}
