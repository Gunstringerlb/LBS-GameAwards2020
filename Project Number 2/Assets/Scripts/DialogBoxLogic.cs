using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxLogic : MonoBehaviour
{
    public string popUp;

    void OnTriggerStay2D(Collider2D other)
    {
            if (Input.GetButtonDown("Interact"))
            {
                Debug.Log(other.name);
                if (other.CompareTag("interObject"))
                {
                    PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
                    pop.PopUp(popUp);

                    Debug.Log("It work now huh?");
                
            }
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);

            Debug.Log("It work now huh?");
        }
    }





}


