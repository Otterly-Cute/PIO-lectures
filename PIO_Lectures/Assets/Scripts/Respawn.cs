using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Rigidbody rb;
    private Animator ani;
    private Vector3 startPos;
    public GameObject particles;
    public GameObject fish;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ani = fish.GetComponent<Animator>();
    }

    void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RespawnCube")
        {
            rb.useGravity = false;
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            ani.enabled = true;
            particles.SetActive(true);
            transform.position = startPos;
        }
    }
}
