using UnityEngine;

public class FingerIKManager : MonoBehaviour
{
    public Transform vrRightHandThumb, vrRightHandIndex, vrRightHandMiddle, vrRightHandRing, vrRightHandPinky;
    public Transform rightThumbTarget, rightIndexTarget, rightMiddleTarget, rightRingTarget, rightPinkyTarget;

    public Vector3 rightThumbTrackingPositionOffset, rightIndexTrackingPositionOffset, rightMiddleTrackingPositionOffset, rightRingTrackingPositionOffset, rightPinkyTrackingPositionOffset;
    public Vector3 rightThumbTrackingRotationOffset, rightIndexTrackingRotationOffset, rightMiddleTrackingRotationOffset, rightRingTrackingRotationOffset, rightPinkyTrackingRotationOffset;


    public Transform vrLeftHandThumb, vrLeftHandIndex, vrLeftHandMiddle, vrLeftHandRing, vrLeftHandPinky;
    public Transform leftThumbTarget, leftIndexTarget, leftMiddleTarget, leftRingTarget, leftPinkyTarget;

    public Vector3 leftThumbTrackingPositionOffset, leftIndexTrackingPositionOffset, leftMiddleTrackingPositionOffset, leftRingTrackingPositionOffset, leftPinkyTrackingPositionOffset;
    public Vector3 leftThumbTrackingRotationOffset, leftIndexTrackingRotationOffset, leftMiddleTrackingRotationOffset, leftRingTrackingRotationOffset, leftPinkyTrackingRotationOffset;


    void Update()
    {
        RightHandIK();
        LeftHandIK();
    }

    void RightHandIK()
    {
        MapRightThumbIK();
        MapRightIndexIK();
        MapRightMiddleIK();
        MapRightRingIK();
        MapRightPinkyIK();
    }

    void LeftHandIK()
    {
        MapLeftThumbIK();
        MapLeftIndexIK();
        MapLeftMiddleIK();
        MapLeftRingIK();
        MapLeftPinkyIK();
    }

    // Right hand helpers
    private void MapRightThumbIK()
    {
        rightThumbTarget.position = vrRightHandThumb.TransformPoint(rightThumbTrackingPositionOffset);
        rightThumbTarget.rotation = vrRightHandThumb.rotation * Quaternion.Euler(rightThumbTrackingRotationOffset);
    }

    private void MapRightIndexIK()
    {
        rightIndexTarget.position = vrRightHandIndex.TransformPoint(rightIndexTrackingPositionOffset);
        rightIndexTarget.rotation = vrRightHandIndex.rotation * Quaternion.Euler(rightIndexTrackingRotationOffset);
    }

    private void MapRightMiddleIK()
    {
        rightMiddleTarget.position = vrRightHandMiddle.TransformPoint(rightMiddleTrackingPositionOffset);
        rightMiddleTarget.rotation = vrRightHandMiddle.rotation * Quaternion.Euler(rightMiddleTrackingRotationOffset);
    }

    private void MapRightRingIK()
    {
        rightRingTarget.position = vrRightHandRing.TransformPoint(rightRingTrackingPositionOffset);
        rightRingTarget.rotation = vrRightHandRing.rotation * Quaternion.Euler(rightRingTrackingRotationOffset);
    }

    private void MapRightPinkyIK()
    {
        rightPinkyTarget.position = vrRightHandPinky.TransformPoint(rightPinkyTrackingPositionOffset);
        rightPinkyTarget.rotation = vrRightHandPinky.rotation * Quaternion.Euler(rightPinkyTrackingRotationOffset);
    }

    // Left hand helpers
    private void MapLeftThumbIK()
    {
        leftThumbTarget.position = vrLeftHandThumb.TransformPoint(leftThumbTrackingPositionOffset);
        leftThumbTarget.rotation = vrLeftHandThumb.rotation * Quaternion.Euler(leftThumbTrackingRotationOffset);
    }

    private void MapLeftIndexIK()
    {
        leftIndexTarget.position = vrLeftHandIndex.TransformPoint(leftIndexTrackingPositionOffset);
        leftIndexTarget.rotation = vrLeftHandIndex.rotation * Quaternion.Euler(leftIndexTrackingRotationOffset);
    }

    private void MapLeftMiddleIK()
    {
        leftMiddleTarget.position = vrLeftHandMiddle.TransformPoint(leftMiddleTrackingPositionOffset);
        leftMiddleTarget.rotation = vrLeftHandMiddle.rotation * Quaternion.Euler(leftMiddleTrackingRotationOffset);
    }

    private void MapLeftRingIK()
    {
        leftRingTarget.position = vrLeftHandRing.TransformPoint(leftRingTrackingPositionOffset);
        leftRingTarget.rotation = vrLeftHandRing.rotation * Quaternion.Euler(leftRingTrackingRotationOffset);
    }

    private void MapLeftPinkyIK()
    {
        leftPinkyTarget.position = vrLeftHandPinky.TransformPoint(leftPinkyTrackingPositionOffset);
        leftPinkyTarget.rotation = vrLeftHandPinky.rotation * Quaternion.Euler(leftPinkyTrackingRotationOffset);
    }
}
