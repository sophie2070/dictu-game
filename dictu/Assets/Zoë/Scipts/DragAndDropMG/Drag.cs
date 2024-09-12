using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{
    private Transform objectToDrag;
    private GameObject objectDetails;
    public Transform correctDestination;
    public Transform incorrectDestination;
    public GameObject objectDetailParent;

    public float Dropdistance;

    //public bool isLocked;

    Vector2 objectInitPos;
    void Start()
    {
        objectDetails = transform.GetChild(0).gameObject;
        objectToDrag = transform;
        objectInitPos = objectToDrag.position;

        objectDetails.SetActive(false);
        objectDetails.transform.parent = objectDetailParent.transform;
    }
    private void FixedUpdate()
    {
        objectDetails.transform.position = objectToDrag.transform.position;
    }

    public void ClickObject(bool status)
    {
        objectDetails.SetActive(status);
    }


    public void DragObject()
    {
        objectToDrag.position = Input.mousePosition;
        objectDetails.SetActive(false);
    }

    public void DropObject()
    {
        if (Vector3.Distance(objectToDrag.position, correctDestination.position) < Dropdistance)
        {
            print("Correct Destination");

            //isLocked = true;
            Destroy(this.gameObject);
            objectToDrag.position = correctDestination.position;
        }
        else if (Vector3.Distance(objectToDrag.position, incorrectDestination.position) < Dropdistance)
        {
            print("Incorrect Destination");

            objectToDrag.position = objectInitPos;
        }
        else
        {
            print("Invalid Destination");

            objectDetails.SetActive(true);
        }
    }
}
