using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image poseImage;

    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void AppearPoseImage()
    {
        poseImage.enabled = !poseImage.enabled;
    }
}
