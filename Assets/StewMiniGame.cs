using TMPro;
using UnityEngine;

public class StewMiniGame : MonoBehaviour, Interaction
{
    PlayerController controller;
    bool startGame = false;
    [SerializeField]
    GameObject textInformation;
    [SerializeField]
    GameObject IngriedientPopUp;
    [SerializeField]
    TMP_Text textToDisplay;
    [SerializeField]
    GameObject indicator;
    float amountOfPresses;
    float timeWhenStarted;

    [SerializeField]
    float toHotAmount, justRight, coldDown;

    float tempature = 0f;
    float toHotTempature = 0f;
    
    public bool playOnce = false;
    public float barAmount;


    bool gameCompleted;
    public void Interact()
    {
        if (playOnce)
        {
            return;

        }
        playOnce = true;


        controller = GameObject.Find("Player").GetComponent<PlayerController>();

        controller.enabled = false;

        startGame = true;
        timeWhenStarted = Time.time;
        IngriedientPopUp.SetActive(true);
        textInformation.SetActive(true);
        //Start MiniGame
        //Click over a certain Time
        //5 seconds
    }

    private void Update()
    {
        if (!startGame || IngriedientPopUp.gameObject.active == true)
        {
            return;
        }

        if (Input.GetKey(KeyCode.P))
        {

        }



        if (gameCompleted)
        {
            startGame = false;
            controller.enabled = true;
            textInformation.SetActive(false);
            textToDisplay.text = "";
            amountOfPresses = 0;
        }

    }
}
