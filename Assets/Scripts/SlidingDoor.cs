using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Slidingdoor : XRBaseInteractable
{
    public Transform transfromDoor;
    
    public Vector3 position;

    void Start()
    {
        //transform of the ahdn
        //position of the door
        //If dot product of the two is less than 0.5, then the door is not valid
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
