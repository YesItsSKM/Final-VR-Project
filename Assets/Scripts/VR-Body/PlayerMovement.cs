using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public OVRPlayerController playerController;

    //public TextMeshProUGUI debugText;

    // Start is called before the first frame update
    void Start()
    {
        //debugText.text = "o";
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

        playerController.HmdRotatesY = true;
    }

    public void MoveForwardUnselected()
    {
        SetHandPoseMoveForward(false);

        playerController.HmdRotatesY = false;

        ResetRotationAfterMovement();
    }

    // Move Backward
    public void MoveBackwardSelected()
    {
        SetHandPoseMoveBackward(true);

        playerController.HmdRotatesY = true;
    }

    public void MoveBackwardUnselected()
    {
        SetHandPoseMoveBackward(false);

        playerController.HmdRotatesY = false;

        ResetRotationAfterMovement();
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

    private void ResetRotationAfterMovement()
    {
        Transform root = playerController.CameraRig.trackingSpace;
        Transform centerEye = playerController.CameraRig.centerEyeAnchor;

        Vector3 prevPos = root.position;
        Quaternion prevRot = root.rotation;

        transform.rotation = Quaternion.Euler(0.0f, centerEye.rotation.eulerAngles.y, 0.0f);

        root.position = prevPos;
        root.rotation = prevRot;
    }
}
