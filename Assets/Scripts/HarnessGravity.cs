using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HarnessGravity : MonoBehaviour
{
    public XRRayInteractor leftHandRay, rightHandRay;

    [SerializeField] Transform obj;
    Rigidbody objRigidBody;

    public float influenceRange;
    public float intensity;
    public float distanceToPlayer;
    
    Vector3 pullForce;

    // Start is called before the first frame update
    void Start()
    {
        obj = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHandRay.TryGetCurrent3DRaycastHit(out RaycastHit hit) && (hit.transform.tag == "Interactable"))
        {
            obj = hit.transform;
            objRigidBody = hit.rigidbody;

            if (!objRigidBody.useGravity)
                objRigidBody.useGravity = true;

            distanceToPlayer = Vector3.Distance(obj.position, transform.position);

            if (distanceToPlayer <= influenceRange)
            {
                pullForce = (transform.position - obj.position).normalized / distanceToPlayer * intensity;
                objRigidBody.AddForce(pullForce, ForceMode.Force);
            }
            
        }

        if (rightHandRay.TryGetCurrent3DRaycastHit(out RaycastHit rHit) && (rHit.transform.tag == "Interactable"))
        {
            obj = rHit.transform;
            objRigidBody = rHit.rigidbody;

            if (!objRigidBody.useGravity)
                objRigidBody.useGravity = true;

            distanceToPlayer = Vector3.Distance(obj.position, transform.position);

            if (distanceToPlayer <= influenceRange)
            {
                pullForce = (transform.position - obj.position).normalized / distanceToPlayer * intensity;
                objRigidBody.AddForce(pullForce, ForceMode.Force);
            }

        }
    }
}
