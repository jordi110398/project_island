using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public void ActivarObjecte()
    { // aqui posarem l'acci� que volguem que realitzi l'objecte amb el que interectuem
        // per defecte l'objecte es destruir� al interactuar
        Destroy(gameObject);
    }
}