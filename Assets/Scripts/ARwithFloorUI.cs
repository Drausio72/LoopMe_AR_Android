using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARwithFloorUI : MonoBehaviour
{
    public GameObject directionsButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDirectionsButton()
    {
        directionsButton.SetActive(false);
    }



    public void OnBackPressed()
    {
        SceneManager.LoadScene(2);
    }
}
