using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class MainScript : MonoBehaviour
{
    public GameObject popMask;
    public GameObject roboMask;
    public ARFaceManager aRFaceManager;
    public Button buttonSwap, buttonSnap; 
    private int flag;
    // Start is called before the first frame update
    void Start()
    {
        buttonSnap.onClick.AddListener(SnapCamera);
        buttonSwap.onClick.AddListener(SwapCamera);
        aRFaceManager.facePrefab = popMask;
        flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SnapCamera()
    {
        string s = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string filename = "arimg" + s + ".png";
        ScreenCapture.CaptureScreenshot(filename);
    }

    void SwapCamera()
    { 
        if (flag == 1)
        {
            aRFaceManager.facePrefab = roboMask;
            flag = 2;
        }
        else if (flag == 2)
        {
            aRFaceManager.facePrefab = popMask;
            flag = 1;
        }
    }
}
