using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportController : MonoBehaviour
{
    public InputActionProperty teleportActivate;
    public XRRayInteractor rightRay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rightRay.gameObject.SetActive(false);

        teleportActivate.action.Enable();
        teleportActivate.action.performed += ActionPerformed;
        teleportActivate.action.canceled += ActionCanceled;
    }

    private void ActionPerformed(InputAction.CallbackContext obj)
    {
        rightRay.gameObject.SetActive(true);
    }

    private void ActionCanceled(InputAction.CallbackContext obj)
    {
        StartCoroutine(SkipOneFrame());
    }

    System.Collections.IEnumerator SkipOneFrame()
    {
        yield return null; // Skip one frame
        rightRay.gameObject.SetActive(false);
    }

}
