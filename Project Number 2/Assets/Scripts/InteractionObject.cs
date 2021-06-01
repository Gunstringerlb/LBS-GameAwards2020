using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private GameObject chatBubble;
    [SerializeField] private TMP_Text displayText;

    public bool talks; // Om sant så kan ett objekt prata med spelaren

    public string message; // Meddelandet objektet kommer att ge till spelaren



    public void Talk()
    {
        Debug.Log(message);
        // Visar meddelandet i konsolen

        displayText.text = message;

        StartCoroutine(TalkCoRoutine());
    }

   public void DoInteraction() 
    { 
        // Plockade upp och förvarade i Inventory
    }

    IEnumerator TalkCoRoutine()
    {
        displayText.text = message;
        chatBubble.SetActive(true);

        yield return new WaitForSeconds(3);

        chatBubble.SetActive(false);
    }
}
