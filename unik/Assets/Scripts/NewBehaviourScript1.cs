using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    bool up;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 1.5f && !up)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
            transform.Rotate (Vector3.up * 900 * Time.deltaTime);
            if(transform.position.y >= 1.5f)
            up = true;
        }  

        else if (transform.position.y > 0 && up)
        {
            transform.Translate(Vector3.up * -1 * Time.deltaTime);
            transform.Rotate (Vector3.up * -900 * Time.deltaTime);
            if(transform.position.y <= 0)
            up = false; 
        }
    }
}
