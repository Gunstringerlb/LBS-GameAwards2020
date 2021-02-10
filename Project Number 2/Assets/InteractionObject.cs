using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public bool talks; // Om sant så kan ett objekt prata med spelaren

    public string message; // Meddelandet objektet kommer att ge till spelaren

    public void Talk()
    {
        Debug.Log(message);
        // Visar meddelnadet i konsolen
    }

   public void DoInteraction() 
    { 
        // Plockade up och förvarade i Inventory
    }
}
