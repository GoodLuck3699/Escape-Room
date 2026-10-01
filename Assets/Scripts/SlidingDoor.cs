using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Slidingdoor : XRBaseInteractable
{
    public Transform transformDoor;
    public float maxDistance;
    public Vector3 localDirection;
    public Vector3 globalDirection;
    public GameObject doorPrefab;
    private Vector3 startPosition;
    private Vector3 endPosition;
    void Start()
    {
        maxDistance = 1;
        globalDirection = Vector3.forward;
        transformDoor = doorPrefab.transform;
        startPosition = transformDoor.position;
        endPosition = startPosition + (globalDirection * maxDistance);
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (isSelected)
        {
            var interactorPos = firstInteractorSelecting.GetAttachTransform(this);
            Vector3 currentDistance = interactorPos.position - startPosition;
            var speed = Vector3.Dot(currentDistance, globalDirection);
            float actualSpeed = -(speed) * Time.deltaTime;
            Debug.Log("endPosition" + endPosition);
            Debug.Log("startPosition" + startPosition);
            Debug.Log("gobalDirection" + globalDirection);
            this.transform.parent.position = Vector3.MoveTowards(startPosition, endPosition, actualSpeed);
        }
    }
}
