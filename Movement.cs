using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float h;
    float v;
    float rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        rot = Input.GetAxis("Horizontal-J2");

        Vector3 direccion = new Vector3(h, v, 0);

        transform.Translate(direccion * 10 * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 100f);
        
    }
}
