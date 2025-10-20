using UnityEngine;

public class CatActivate : MonoBehaviour
{
    public GameObject britishCat;
    public GameObject angoraCat;
    public GameObject ragdollCat;

    public GameObject britishParticle;
    public GameObject angoraParticle;
    public GameObject ragdollParticle;

    public GameObject summoningCircle;

    public Material purple;
    public Material blue;
    public Material green;

    public bool britishActivated;
    public bool angoraActivated;
    public bool ragdollActivated;

    public AudioSource Bmeow;
    public AudioSource Ameow;
    public AudioSource Rmeow;

    //public AudioSource purr;



    private void Start()
    {
        britishActivated = false;
        angoraActivated = false;
        ragdollActivated = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Player")
        {
            if (other.gameObject == britishCat)
            {
                Debug.Log("British collision");
                if (britishActivated == false)
                {
                    ActivateGlow(purple);
                    Bmeow.Play();
                    britishParticle.SetActive(true);
                    britishActivated=true;
                    CheckActivation();
                }
            }
            else if (other.gameObject == angoraCat)
            {
                Debug.Log("Angora collision");
                if (angoraActivated == false)
                {
                    ActivateGlow(blue);
                    Ameow.Play();
                    angoraParticle.SetActive(true);
                    angoraActivated = true;
                    CheckActivation();
                }
            }
            else if (other.gameObject == ragdollCat)
            {
                Debug.Log("Ragdoll collision");
                if (ragdollActivated == false)
                {
                    ActivateGlow(green);
                    Rmeow.Play();
                    ragdollParticle.SetActive(true);
                    ragdollActivated = true;
                    CheckActivation();
                }
            }
        }
    }

    public void ActivateGlow (Material color)
    {
        color.EnableKeyword("_EMISSION");
    }

    public void CheckActivation()
    {
        if (britishActivated == true && angoraActivated == true && ragdollActivated == true)
        {
            ActivateSummoning();
        }
    }

    public void ActivateSummoning()
    {
        summoningCircle.SetActive(true);
        //purr.Play();
    }

   


}
