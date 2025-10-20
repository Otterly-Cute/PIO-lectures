using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Interactables : MonoBehaviour
{
    public GameObject ParticleSystem;
    public GameObject ghost;
    private IEnumerator hit;
    public AudioSource purr;
    public AudioSource meow;

    private void Start()
    {
        hit = WaitAndDestroy(3.0f);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            Debug.Log("trigger");
            purr.Stop();
            meow.Play();
            ParticleSystem.SetActive(true);
            ghost.SetActive(false);
            StartCoroutine(hit);
        }
    }

    IEnumerator WaitAndDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this);
    }



}
