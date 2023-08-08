using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // display message when player looks at interactable object
    public string promptMessage;
    // this will be called from the player object 
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        // this is a template function to be overwritten by the subclass
    }
}
