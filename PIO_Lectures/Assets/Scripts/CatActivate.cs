using UnityEngine;

public class CatActivate : MonoBehaviour
{
    public GameObject britishCat;
    public GameObject angoraCat;
    public GameObject ragdollCat;

    public Material purple;
    public Material blue;
    public Material green;


   

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.gameObject == britishCat)
            {
                britishCat.SetActive(true);
                ActivateGlow(purple);
            }
            else if (this.gameObject == angoraCat)
            {
                angoraCat.SetActive(true);
                ActivateGlow(blue);
            }
            else if (this.gameObject == ragdollCat)
            {
                ragdollCat.SetActive(true);
                ActivateGlow(green);
            }
        }
    }


    public void ActivateGlow (Material color)
    {
        color.EnableKeyword("_EMISSION");
    }

}
