using System.Collections;
using TMPro;
using UnityEngine;

interface Interaction
{
    public void Interact();
}


public class MachineInteraction : MonoBehaviour, Interaction
{
    [SerializeField]
    TMP_Text textObject;

    bool firstInteraction = true;
    bool AlreadyInteracted = false;

    [SerializeField]
    int amountOfIngredientNeeded = 3;
    int currentAmountOfMoney = 0;

    [SerializeField]
    SliceMiniGame sliceMinigame;
    [SerializeField]
    StewMiniGame stewMinigame;

    public void Interact()
    {
        if (AlreadyInteracted)
        {
            return;
        }

        if (firstInteraction)
        {
            firstInteraction = false;
            AlreadyInteracted = true;
            //Start Generating image here

            StartCoroutine("loading");
        }
        else
        {
            currentAmountOfMoney += 1;
            if (currentAmountOfMoney >= amountOfIngredientNeeded)
            {
                AlreadyInteracted = true;
                StartCoroutine("Done");
            }
            else
            {
                RenderText();
            }
        }
    }

    private IEnumerator Done()
    {
        RenderText();
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        textObject.text = "Done";
        //Spawn the Object Here
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        
        textObject.text = "Start";
        currentAmountOfMoney = 0;
        stewMinigame.playOnce = false;
        sliceMinigame.playOnce = false;
        firstInteraction = true;
        AlreadyInteracted = false;

        yield return null;
    }



    private void RenderText()
    {
        textObject.text = $"{currentAmountOfMoney}/{amountOfIngredientNeeded}";
    }



    private IEnumerator loading()
    {
        textObject.text = ".";
        yield return new WaitForSeconds(Random.Range(0.5f,1f));
        textObject.text = "..";
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        textObject.text = "...";
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        textObject.text = "....";
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        textObject.text = "Prepare";
        yield return new WaitForSeconds(0.5f);
        RenderText();
        AlreadyInteracted = false;
        yield return null;
    }

}


