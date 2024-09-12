using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.GetComponent<Renderer>().enabled = false;
            audioManager.Play("door_1");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        door.GetComponent<Renderer>().enabled = true;
    }
}
