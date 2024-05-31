using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ARTRackerManager : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    private int fileVersion = 0;

    // Start is called before the first frame update
    public void LionIsVisible()
    {
        MainManager.Instance.isLionVisible = true;
    }

    public void LionIsNotVisible()
    {
        MainManager.Instance.isLionVisible = false;
    }

    private void Update()
    {

    }

    public void ClickAndShare()
    {
        /*ScreenCapture.CaptureScreenshot(Application.streamingAssetsPath + "/CameraScreenshot.png");
        Debug.Log("Screenshot Saved");*/
        fileVersion++;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        StartCoroutine(LoadFile());

        
    }

    IEnumerator LoadFile()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img" + fileVersion + ".png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        ScreenCapture.CaptureScreenshot(filePath);



        // To avoid memory leaks
        Destroy(ss);

        new NativeShare().AddFile(filePath).SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget)).Share();

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
    }
}
