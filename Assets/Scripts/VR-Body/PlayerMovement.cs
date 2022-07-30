using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public OVRPlayerController playerController;

    public TextMeshProUGUI debugText;

    // Start is called before the first frame update
    void Start()
    {
        debugText.text = "o";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*
        LOCOMOTION
     */

    // Move Forward
    public void MoveForwardSelected()
    {
        SetHandPoseMoveForward(true);
    }

    public void MoveForwardUnselected()
    {
        SetHandPoseMoveForward(false);
    }

    // Move Backward
    public void MoveBackwardSelected()
    {
        SetHandPoseMoveBackward(true);
    }

    public void MoveBackwardUnselected()
    {
        SetHandPoseMoveBackward(false);
    }


    // Rotate Right
    public void RotateRightSelected()
    {
        SetHandPoseRotateRight(true);
    }

    public void RotateRightUnselected()
    {
        SetHandPoseRotateRight(false);
    }

    // Rotate Left
    public void RotateLeftSelected()
    {
        SetHandPoseRotateLeft(true);
    }

    public void RotateLeftUnselected()
    {
        SetHandPoseRotateLeft(false);
    }


    // STATE MANAGERS
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
