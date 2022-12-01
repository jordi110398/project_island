using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject comporta;
    [SerializeField]
    GameObject placa;

    bool isOpened = false;

    void OnTriggerStay(Collider col)
    {
        //Debug.Log("Hello");
        if (!isOpened)
        {
            //Debug.Log("S'ha obert");
            
            //placa.transform.position += new Vector3(0, -0.05f, 0);
            isOpened = true;
            int contador = 0;
            while(isOpened && contador <= 4) {
                comporta.transform.position += new Vector3(0, contador, 0);
                contador++;
            }
            isOpened = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        //Debug.Log("Hello");
        //Debug.Log("S'ha obert");
        comporta.transform.position += new Vector3(0, -4, 0);
        //placa.transform.position += new Vector3(0, +0.05f, 0);
        //isOpened = false;
    }
}
