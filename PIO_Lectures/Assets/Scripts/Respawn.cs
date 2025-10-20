using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Rigidbody rb;
    private Animator ani;
    private Vector3 startPos;
    public GameObject particles;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
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
            ani.StartPlayback();
            particles.SetActive(true);
            transform.position = startPos;
        }
    }
}
