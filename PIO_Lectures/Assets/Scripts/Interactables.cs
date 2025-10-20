using UnityEngine;
using System.Collections;

public class Interactables : MonoBehaviour
{
    public GameObject interactables;
    public GameObject witchCat;


    IEnumerator WaitAndSpawn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        interactables.SetActive(true);
    }



}
