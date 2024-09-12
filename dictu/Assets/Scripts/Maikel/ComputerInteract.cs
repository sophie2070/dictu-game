using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerInteract : MonoBehaviour
{
    private GameObject playeractive;
    public GameObject speechbubble;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playeractive = other.gameObject;
            speechbubble.GetComponent<Renderer>().enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playeractive = null;
            speechbubble.GetComponent<Renderer>().enabled = false;
        }
    }
        // Update is called once per frame
        void Update()
    {
        if (playeractive && Input.GetKeyDown(KeyCode.E)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }  
}
