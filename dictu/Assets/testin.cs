using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testin : MonoBehaviour
{
    AudioManager aman;
    void Start()
    {
        aman = GetComponent<AudioManager>();
        aman.Play("bab");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
