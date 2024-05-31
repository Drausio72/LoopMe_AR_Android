using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToMainMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator GoToMainMenu()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(1);

    }
}
