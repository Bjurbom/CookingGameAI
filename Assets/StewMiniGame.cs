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

    HitObject hitObject;
    StewMiniGameSystem system;


    private void Start()
    {
        hitObject = indicator.GetComponentInChildren<HitObject>();
        system = indicator.GetComponent<StewMiniGameSystem>();
    }


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
    }

    private void Update()
    {
        if (!startGame || IngriedientPopUp.gameObject.active == true)
        {
            return;
        }

        indicator.SetActive(true);

        if (Input.GetKeyDown(KeyCode.P))
        {
            hitObject.SeeIfHit();
            
        }

        if (system.Over)
        {
            gameCompleted = true;
        }



        if (gameCompleted)
        {
            gameCompleted = false;
            indicator.SetActive(false);
            system.Start();
            startGame = false;
            controller.enabled = true;
            textInformation.SetActive(false);
            textToDisplay.text = "";
            amountOfPresses = 0;
        }

    }
}
