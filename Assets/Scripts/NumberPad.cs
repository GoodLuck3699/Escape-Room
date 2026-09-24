using System.ComponentModel;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;

public class NumberPad : MonoBehaviour
{
    readonly private int[] password = {1,2,3,4};
    private int currentIndex;

    public void PressedButton()
    {

    }


    

}
// take the values from the hovered and put that into an array
// so if the length of password entered is equal to the length of the actual password, then move onto the next if stateent.
// If the password is equal to the correct array password, then call the keycard
// if the password isn't equal, then reset the script

