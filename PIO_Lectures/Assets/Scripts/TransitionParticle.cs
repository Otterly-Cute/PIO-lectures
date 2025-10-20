using UnityEngine;
using System.Collections;

public class TransitionParticle : MonoBehaviour
{
    public GameObject particles;
    public GameObject witchCat;
    public GameObject interactables;
    public GameObject ghosts;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particles.SetActive(true);
            WaitAndActivate(5.0f);

        }
    }

    IEnumerator WaitAndActivate(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        witchCat.SetActive(true);
        interactables.SetActive(true);
        ghosts.SetActive(true);
    }

}
