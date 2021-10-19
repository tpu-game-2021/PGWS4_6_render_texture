using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    private float forward = 0.0f;
    private float side = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        const float FORWARD_ACCLERATION= 0.3f;// 速度調整パラメータ
        const float SIDE_ACCLERATION = 10.0f;
        if (Input.GetKey(KeyCode.W))
        {
            forward += FORWARD_ACCLERATION;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forward -= FORWARD_ACCLERATION;
        }
        if (Input.GetKey(KeyCode.A))
        {
            side -= SIDE_ACCLERATION;
        }
        if (Input.GetKey(KeyCode.D))
        {
            side += SIDE_ACCLERATION;
        }

        transform.Translate(Vector3.forward * forward * Time.deltaTime);
        transform.Rotate(Vector3.up * side * Time.deltaTime);

        forward *= 0.9f;
        side *= 0.9f;
    }
}
