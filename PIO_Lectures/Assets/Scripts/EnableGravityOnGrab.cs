using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class EnableGravityOnGrab : MonoBehaviour
{
    private Rigidbody rb;
    private XRBaseInteractable interactable;
    private Animator ani;
    public GameObject particles;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        interactable = GetComponent<XRBaseInteractable>();
    }

    private void OnEnable()
    {
        // Subscribe to select event (when picked up)
        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (rb != null)
        {
            rb.useGravity = true;
            ani.StopPlayback();
            particles.SetActive(false);
        }
    }



}
