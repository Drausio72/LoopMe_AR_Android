using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionsPage : MonoBehaviour
{
    public Button okButton;

    // Start is called before the first frame update
    public void OnOKPressed()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenURL()
    {
        Application.OpenURL("https://loopme.com/ar-app-privacy-policy/");
    }
}
