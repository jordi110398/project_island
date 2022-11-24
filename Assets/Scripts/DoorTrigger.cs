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

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hello");
        if (!isOpened)
        {
            Debug.Log("S'ha obert");
            comporta.transform.position += new Vector3(0, 4, 0);
            placa.transform.position += new Vector3(0, -0.05f, 0);
            isOpened = true;
        }
    }
}
