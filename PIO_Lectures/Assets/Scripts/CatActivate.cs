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

    public void ActivateGlow (Material color)
    {
        color.EnableKeyword("_EMISSION");
    }

}
