using UnityEngine;
using UnityEngine.UI;

public class CakeDisplayScript : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] GameObject CakeUI;

    private void Start()
    {
        closeButton.onClick.AddListener(() => CloseWindow());
    }

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    public void CloseWindow()
    {
        CakeUI.SetActive(false);
        Time.timeScale = 1;
    }
}
