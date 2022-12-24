using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject placa1;
    [SerializeField]
    GameObject placa2;
    [SerializeField]
    GameObject placa3;
    [SerializeField]
    GameObject placa4;
    [SerializeField]
    GameObject porta;

    EstaActiva estaActiva1;
    EstaActiva estaActiva2;
    EstaActiva estaActiva3;
    EstaActiva estaActiva4;

    bool isOpened = false;
    

    void Awake()
    {
        estaActiva1 = placa1.GetComponent<EstaActiva>();
        estaActiva2 = placa2.GetComponent<EstaActiva>();
        estaActiva3 = placa3.GetComponent<EstaActiva>();
        estaActiva4 = placa4.GetComponent<EstaActiva>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estaActiva1.activada && estaActiva2.activada && estaActiva3.activada && estaActiva4.activada)
        {
            //Debug.Log("PORTA PRINCIPAL ACTIVADA");
            porta.transform.position += new Vector3(0, 4, 0);
            isOpened = true;
        }
    }
}
