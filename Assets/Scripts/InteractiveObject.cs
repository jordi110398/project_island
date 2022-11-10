using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public bool interactuable = false;
    public global::System.Boolean Interactuable { get => interactuable; set => interactuable = value; }

    public bool esInteractuable()
    {
        return interactuable;   
    }

    public void ActivarObjecte()
    { // aqui posarem l'acció que volguem que realitzi l'objecte amb el que interectuem
        // per defecte l'objecte es destruirà al interactuar
        Destroy(gameObject);
    }

    /************* Sistema per determinar si l'objecte es pot moure o agafar *************/
    public bool pesPetit = false;
    public bool pesGran = false;

    public global::System.Boolean PesPetit { get => pesPetit; set => pesPetit = value; }
    public global::System.Boolean PesGran { get => pesGran; set => pesGran = value; }

    public bool esPetit()
    {
        return pesPetit;
    }

    public bool esGran()
    {
        return pesGran;
    }
    /************* Sistema per determinar si l'objecte es pot moure o agafar *************/
}
