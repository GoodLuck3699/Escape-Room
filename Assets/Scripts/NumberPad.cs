using System.ComponentModel;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class NumberPad : MonoBehaviour
{
    private string Password = "1234";
    private string currentPassword = "";
    [Header("Keycard Data")]
    public GameObject keycardPrefab;
    public Transform attachPoint;
    public TextMeshProUGUI CodeDisplayText;

    public void ButtonPad(string pressedValue)
    {
        currentPassword += pressedValue;
        CodeDisplayText.SetText("Password" + currentPassword);

        if (currentPassword.Length == Password.Length)
        {
            if (currentPassword == Password)
            {
                Instantiate(keycardPrefab, attachPoint.position, attachPoint.rotation);
            }
            else
            {
                CodeDisplayText.SetText("Incorrect Code");
                currentPassword = null;
            }
        }
    } 
}
    /*
    protected void 

    private GameObject keycardInstance;
    readonly private int[] password = {1,2,3,4};
    private int currentIndex;
    private int[] enteredPassword = {0,0,0,0};
 
    [Header("Keycard Data")]

    public Transform attachPoint;
    public TextMeshProUGUI CodeDisplayText;

    public void ButtonPad(int pressedValue)
    {
        enteredPassword[currentIndex] = pressedValue;
        currentIndex++;
        CodeDisplayText.SetText(enteredPassword[0].ToString() + enteredPassword[1].ToString() + enteredPassword[2].ToString() + enteredPassword[3].ToString());

        if (currentIndex == password.Length)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (enteredPassword[i] != password[i])
                {
                    CodeDisplayText.SetText("Incorrect Code");
                    currentIndex = 0;
                }
                else
                {
                    keycardInstance = Instantiate(keycardPrefab, attachPoint.position, attachPoint.rotation);
                    currentIndex = 0;
                }
            }
        }
    currentIndex = 0;
}
    

    }



// take the values from the hovered and put that into an array
// so if the length of password entered is equal to the length of the actual password, then move onto the next if stateent.
// If the password is equal to the correct array password, then call the keycard
// if the password isn't equal, then reset the script

*/