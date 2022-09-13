using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float CPSlimit = 1.0f;
    float timeout = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeout > 0)
            timeout -= Time.deltaTime;
        // On spacebar press, send dog
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            timeout = CPSlimit;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}