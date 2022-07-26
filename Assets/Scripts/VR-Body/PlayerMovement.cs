using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public OVRPlayerController playerController;

    public TextMeshProUGUI debugText;

    private bool HandPoseMoveForward = false;
    private bool HandPoseMoveBackward = false;
    private bool HandPoseRotateRight = false;
    private bool HandPoseRotateLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        debugText.text = "Testing begins!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThumbsUpSelected()
    {
        debugText.text = "Thumbs Up";

        playerController.EnableLinearMovement = true;

        
    }

    public void ThumbsUpUnselected()
    {
        debugText.text = ".";
    }

    public void SetHandPoseMoveForward(bool state)
    {
        HandPoseMoveForward = state;
    }
    public void SetHandPoseMoveBackward(bool state)
    {
        HandPoseMoveBackward = state;
    }
    public void SetHandPoseRotateRight(bool state)
    {
        HandPoseRotateRight = state;
    }
    public void SetHandPoseRotateLeft(bool state)
    {
        HandPoseRotateLeft = state;
    }
}
