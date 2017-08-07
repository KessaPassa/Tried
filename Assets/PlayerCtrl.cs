using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
    private UIManager uiManager;
	
	void Start () {
        uiManager = FindObjectOfType<UIManager>();
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uiManager.AppearPoseImage();
        }
	}
}
