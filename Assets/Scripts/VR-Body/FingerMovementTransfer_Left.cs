using UnityEngine;
using TMPro;

public class FingerMovementTransfer_Left : MonoBehaviour
{
    public Transform[] trackedThumbJoints;

    public Transform[] thumbJoints;

    public Vector3 rotationOffset;

    public TextMeshProUGUI targetRot, objRot;

    private int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (i = 0; i < 3; i++)
        {
            Vector3 newRotation = new Vector3(trackedThumbJoints[i].eulerAngles.x, trackedThumbJoints[i].eulerAngles.y, -trackedThumbJoints[i].eulerAngles.z);

            newRotation += rotationOffset;

            thumbJoints[i].transform.eulerAngles = newRotation;
        }

        i = 0;
    }
}
