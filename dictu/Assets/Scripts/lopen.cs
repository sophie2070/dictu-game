using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopen : MonoBehaviour
{
    AudioManager audioManager;
    Player player;
    bool passed = false;
    void Start()
    {
        player = GetComponent<Player>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }


    void Update()
    {
        if (player.horizontalMove != 0 && passed == false || player.verticalMove != 0 && passed == false)
        {
            StartCoroutine(Walk());
        }
    }

    IEnumerator Walk()
    {
        audioManager.Play("step_1");
        Debug.Log("a");
        passed = true;
        yield return new WaitForSeconds(0.2f);
        passed = false;
    }
}
