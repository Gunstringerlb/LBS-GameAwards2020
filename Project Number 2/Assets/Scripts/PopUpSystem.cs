using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem: MonoBehaviour
{
    public GameObject dialogBox; // Detta kommer skapa en referens till ett GameObject som kommer agera som bakgrund till dialogboxen
    public Animator animator; // Detta skapar en referens till PopUpAnimationen till dialogboxen
    public TMP_Text dialogText; // Detta skapar en referens till själva texten i dialogboxen

    public void PopUp(string text)
    {
        dialogBox.SetActive(true);
        dialogText.text = text;
        animator.SetBool("pop", true);
    }

}
