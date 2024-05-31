using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour, ISelectHandler
{
    public Button proceedButton;
    public Button inYourHandButton;
    public Button inTheFloorButton;

    private void Start()
    {
        proceedButton.interactable = false;
    }

    private void Update()
    {
        if(MainManager.Instance.selectedButton > 0)
        {
            proceedButton.interactable = true;
        } else
        {
            proceedButton.interactable = false;
        }
    }

    public void OnSelect(BaseEventData eventData)
    {
        MainManager.Instance.selectedButton = 0;

    }

    public void OnProceedPressed()
    {
        if (MainManager.Instance.selectedButton == 1)
        {
            inYourHandButton.interactable = false;
            SceneManager.LoadScene(4);
        }
        if (MainManager.Instance.selectedButton == 2)
        {
            inTheFloorButton.interactable = false;
            SceneManager.LoadScene(3);
        }
    }
}

