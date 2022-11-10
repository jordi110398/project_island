using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 1.5f;

    //public Texture2D punter; 
    public GameObject TextDetect;
    GameObject ultimReconegut = null;

    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Raycast(origen, direcci�, out hit, distancia, m�scara)

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        { // el raycast ha impactat amb un objecte que ha complert les condicions
            Deselect();
            SelectedObject(hit);
            if (hit.collider.tag == "InteractiveObject" & hit.collider.GetComponent<InteractiveObject>().esInteractuable())
            { // podem interactuar amb aquest objecte
                if (Input.GetKeyDown(KeyCode.E))
                { // s'ha premut la tecla per interactuar
                    hit.collider.transform.GetComponent<InteractiveObject>().ActivarObjecte();
                }
            }
            // Per si vos veure el RayCast
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distancia, Color.red);
        }
        else
        {
            Deselect();
        }
    }

    // S'encarrega de canviar el color del material amb el que ha impactat el RayCast
    void SelectedObject(RaycastHit hit)
    {
        if (hit.collider.GetComponent<InteractiveObject>().esInteractuable()) {
            hit.transform.GetComponent<MeshRenderer>().material.color = Color.green;
            ultimReconegut = hit.transform.gameObject;
        }
    }

    // S'encarrega de deseleccionar l'objecte
    void Deselect()
    {
        if (ultimReconegut)
        { // no es null. Hi ha un objecte seleccionat
            ultimReconegut.GetComponent<Renderer>().material.color = Color.grey; // color normal de l'objecte
            ultimReconegut = null;
        }
    }

    // S'encarrega de dibuixar el punter. Si ni ha
    private void OnGUI()
    {
        if (ultimReconegut)
        { // no �s null
            TextDetect.SetActive(true);
        }
        else
        { // �s null
            TextDetect.SetActive(false);
        }
    }
}