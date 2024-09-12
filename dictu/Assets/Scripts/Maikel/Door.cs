using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.GetComponent<Renderer>().enabled = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        door.GetComponent<Renderer>().enabled = true;
    }
}
