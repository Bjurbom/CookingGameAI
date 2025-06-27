using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<string> ingriedientNames= new List<string>();

    [SerializeField] int amountOfIngredientRequierdToMake;
    bool startedGenerating = false;
    bool doneGenerating = false;
    public bool HaveCake = false;

    private void Update()
    {
        if (amountOfIngredientRequierdToMake <= ingriedientNames.Count && !startedGenerating)
        {
            startedGenerating = true;
            StartCoroutine("GeneratingImage");
            Debug.Log("Generating");
        }
    }

    IEnumerator GeneratingImage()
    {
        yield return new WaitForSeconds(10f); //Generate the image here
        Debug.Log("Done");
        HaveCake = true;
        doneGenerating = true;
        ResetList();
        yield return null;
    }

    public void ResetList()
    {
        ingriedientNames.Clear();
    }
}
