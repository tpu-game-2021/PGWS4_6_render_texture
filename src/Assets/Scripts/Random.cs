using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    [SerializeField]private GameObject create;
    [SerializeField] private Transform rangeA;
    [SerializeField] private Transform rangeB;
    private float time=0.0f;
    [SerializeField] private float interval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        time = time += Time.deltaTime;
        if (time > interval)
        {
            float x = UnityEngine.Random.Range(rangeA.position.x, rangeB.position.x);
            float y = UnityEngine.Random.Range(rangeA.position.y, rangeB.position.y);
            float z = UnityEngine.Random.Range(rangeA.position.z, rangeB.position.z);


            Instantiate(create, new Vector3(x, y, z), create.transform.rotation);
            time = 0f;
        }
    }
}
