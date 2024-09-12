using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointmove : MonoBehaviour
{
    public GameObject whatever;
    [SerializeField]
    float minX;
    [SerializeField]
    float minY;
    [SerializeField]
    float maxX;
    [SerializeField]
    float maxY;
    private Vector2 startpos;
    void Start()
    {
        startpos = transform.position;
        StartCoroutine(move());
    }

    void Update()
    {
        
    }

    IEnumerator move()
    {
        transform.position = startpos;
        var cricle = Random.insideUnitCircle.normalized * 500;
        cricle.y *= 0.5f;
        cricle += startpos;


        bool done = false;
        while (!done)
        {
            transform.position = Vector2.Lerp(transform.position,cricle, 10 * Time.deltaTime);
            if (Vector2.Distance(transform.position, cricle) <= 5)
            {
                done = true;
            }
            yield return new WaitForEndOfFrame();
        }
        yield return null;
        GameObject.Instantiate(whatever,transform.position,Quaternion.identity);
        StartCoroutine(move());
    }
}
