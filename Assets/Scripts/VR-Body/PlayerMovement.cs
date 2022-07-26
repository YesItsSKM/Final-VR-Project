using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public OVRPlayerController playerController;

    public TextMeshProUGUI debugText;

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
        //debugText.text = "Thumbs Up";

            debugText.text = "Can move";
            SetHandPoseMoveForward(true);

        //playerController.EnableLinearMovement = true;
    }

    public void ThumbsUpUnselected()
    {

            debugText.text = "Can't move";
        SetHandPoseMoveForward(false);
       
    }

    public void SetHandPoseMoveForward(bool state)
    {
        playerController.HandPoseMoveForward = state;
    }
    public void SetHandPoseMoveBackward(bool state)
    {
        playerController.HandPoseMoveBackward = state;
    }
    public void SetHandPoseRotateRight(bool state)
    {
        playerController.HandPoseRotateRight = state;
    }
    public void SetHandPoseRotateLeft(bool state)
    {
        playerController.HandPoseRotateLeft = state;
    }
}
