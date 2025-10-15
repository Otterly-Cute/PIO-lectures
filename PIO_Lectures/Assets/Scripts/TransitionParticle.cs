using UnityEngine;

public class TransitionParticle : MonoBehaviour
{
    public GameObject particles;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particles.SetActive(true);


        }
    }

}
