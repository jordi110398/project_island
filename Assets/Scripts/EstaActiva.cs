using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstaActiva : MonoBehaviour
{
    [SerializeField]
    GameObject placa;

    public bool activada = false;


    void OnTriggerStay(Collider col)
    {
        //Debug.Log("Placa activada");
        activada = true;
    }

    void OnTriggerExit(Collider col)
    {
        activada = false;
    }
}
