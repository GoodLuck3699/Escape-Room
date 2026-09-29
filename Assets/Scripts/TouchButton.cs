using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class TouchButton : XRBaseInteractable
{

    private string buttonNumber;
    public NumberPad theNumberPad;
    [Header("Keycard Data")]
    public Material touchedMaterial;
    public Material normalMaterial;

    public void OnStart()
    {
        normalMaterial = this.GetComponent<MeshRenderer>().material;
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        this.GetComponent<MeshRenderer>().material = touchedMaterial;
        buttonNumber = gameObject.name;
        theNumberPad.ButtonPad(buttonNumber);

    }
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        this.GetComponent<MeshRenderer>().material = normalMaterial;
    }
}
