using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class TouchButton : XRBaseInteractable
{

    private NumberPad numberPad;
    private int buttonNumber;
    private Renderer changeMaterial;
    private Material TouchedMaterial;
    private Material NormalMaterial;

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        changeMaterial.material = TouchedMaterial;
        numberPad.ButtonPad(buttonNumber);

    }
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        changeMaterial.material = NormalMaterial;


    }
}
