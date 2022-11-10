using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public void ActivarObjecte()
    { // aqui posarem l'acció que volguem que realitzi l'objecte amb el que interectuem
        // per defecte l'objecte es destruirà al interactuar
        Destroy(gameObject);
    }
}