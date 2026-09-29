using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CardReader : XRSocketInteractor
{
    [Header("Keycard Data")]
    public GameObject keycardPrefab;
    Transform cardTransform;
    Vector2 cardPosition;
    bool isValid;
    Vector3 distance;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return false;
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        cardTransform = keycardPrefab.transform;
        Vector2 cardPosition = cardTransform.position;
        isValid = true;

    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        
    }
}
