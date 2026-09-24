using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class TouchButton : XRBaseInteractable
{
    [Header("Buttons")]
    public Transform attachPoint;
    public NumberPad balloonPrefab;

    private NumberPad buttonNumber;
    private Material TouchedMaterial;
    private Material NormalMaterial;

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        buttonNumber = new NumberPad();
        NumberPad.Material = TouchedMaterial;
        NumberPad.Sequence(NumberPad buttonNumber);

    }
    protected override void OnHoverExited(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        buttonNumber = new NumberPad();
        NumberPad.Material = NormalMaterial;


    }
}
