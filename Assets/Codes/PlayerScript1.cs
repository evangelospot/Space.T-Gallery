using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript1: MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Convert user input into world movement
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 6f;

        // Apply movement to player's transform
        transform.Rotate(0, moveX, 0);
        transform.Translate(0, 0, moveZ);
    }
}
