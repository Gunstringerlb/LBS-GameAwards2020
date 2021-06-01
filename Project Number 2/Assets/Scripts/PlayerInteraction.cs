using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public InteractionObject currentInterObjScript = null;

    void Update()
    {
        if(Input.GetButtonDown ("Interact") && currentInterObj) {
            
            
            // Gör något med objektet
            currentInterObj.SendMessage("DoInteraction");

            // Kollar om objektet talar och har ett meddelande
            if (currentInterObjScript.talks)
            {
                // Säger till objektet att ge sitt meddelande
                currentInterObjScript.Talk();
            }
        }
       
     
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            if (other.gameObject == currentInterObj)
            {

                currentInterObj = null;
            }

        }

    }
}
