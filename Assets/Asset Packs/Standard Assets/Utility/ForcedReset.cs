using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Include this namespace
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    public Image uiImage; // Reference to the UI.Image component

    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
