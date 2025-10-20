using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class EnableGravityOnGrab : MonoBehaviour
{
    private Rigidbody rb;
    private XRBaseInteractable interactable;
    private Animator ani;
    public GameObject particles;
    public GameObject fish;
    private bool gravityEnabled = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ani = fish.GetComponent<Animator>();
        interactable = GetComponent<XRBaseInteractable>();
    }

    private void OnEnable()
    {
        // Subscribe to select event (when picked up)
        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.selectExited.AddListener(OnSelectExited);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnSelectEntered);
        interactable.selectExited.RemoveListener(OnSelectExited);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (rb != null && !gravityEnabled)
        {
            rb.useGravity = true;
            ani.enabled = false;
            particles.SetActive(false);
            gravityEnabled = true;
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        if (rb != null)
        {
            rb.useGravity = true;
        }



    }
}
