using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class NumberPad : MonoBehaviour
{
    private GameObject keycardInstance;
    readonly private int[] password = {1,2,3,4};
    private int currentIndex;
    private int[] enteredPassword = {0,0,0,0};

    public TextMeshProUGUI InputDisplayText;  
    [Header("Keycard Data")]
    public GameObject keycardPrefab;
    public Transform attachPoint;
    public TextMeshProUGUI CodeDisplayText;

public void ButtonPad(int pressedValue)
{
    enteredPassword[currentIndex] = pressedValue;
    currentIndex++;
    CodeDisplayText.SetText(enteredPassword[0].ToString() + enteredPassword[1].ToString() + enteredPassword[2].ToString() + enteredPassword[3].ToString());

    if (currentIndex < password.Length)
    {
        ;
    }

    for (int i = 0; i < password.Length; i++)
    {
        if (enteredPassword[i] != password[i])
        {
            CodeDisplayText.SetText("Incorrect Code");
            currentIndex = 0;
            System.Array.Clear(enteredPassword, 0, enteredPassword.Length);
            return;
        }
    }

    keycardInstance = Instantiate(keycardPrefab, attachPoint.position, attachPoint.rotation);
    currentIndex = 0;
}
    

    }



// take the values from the hovered and put that into an array
// so if the length of password entered is equal to the length of the actual password, then move onto the next if stateent.
// If the password is equal to the correct array password, then call the keycard
// if the password isn't equal, then reset the script

