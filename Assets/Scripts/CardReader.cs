using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CardReader : XRSocketInteractor
{
    private Transform cardTransform;
    private Vector3 InitialPosition;
    private Vector3 Distance;
    private bool isValid;
    [Header("Studd I need")]
    public GameObject cardreaderPrefab;
    public GameObject DoorLockPrefab;


    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return false;
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        cardTransform = cardreaderPrefab.transform;
        InitialPosition = cardTransform.position;
        isValid = true;

    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        Vector3 Distance = cardTransform.position - InitialPosition;
        if (isValid == true && Distance.magnitude > 0.1f)
        {
            DoorLockPrefab.SetActive(false);
        }
    }

    public void Update()
    {
        Vector3 readerUp = transform.up;
        Vector3 worldUp = Vector3.up;
        if (Vector3.Dot(readerUp, worldUp) < 0.5f)
        {
            isValid = false;
        }
    }
}
