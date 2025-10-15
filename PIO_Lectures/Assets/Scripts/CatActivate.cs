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

    public bool britshActivated = false;
    public bool angoraActivated = false;
    public bool ragdollActivated = false;

    public AudioSource Bmeow;
    public AudioSource Ameow;
    public AudioSource Rmeow;

    public AudioSource purr;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.gameObject == britishCat)
            {
                if (britshActivated == false)
                {
                    ActivateGlow(purple);
                    Bmeow.Play();
                    britishParticle.SetActive(true);
                    britshActivated=true;
                    CheckActivation();
                }
            }
            else if (this.gameObject == angoraCat)
            {
                if (angoraActivated == false)
                {
                    ActivateGlow(blue);
                    Ameow.Play();
                    angoraParticle.SetActive(true);
                    angoraActivated = true;
                    CheckActivation();
                }
            }
            else if (this.gameObject == ragdollCat)
            {
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
        if (britshActivated == true && angoraActivated == true && ragdollActivated == true)
        {
            ActivateSummoning();
        }
    }

    public void ActivateSummoning()
    {
        summoningCircle.SetActive(true);
        purr.Play();
    }
}
