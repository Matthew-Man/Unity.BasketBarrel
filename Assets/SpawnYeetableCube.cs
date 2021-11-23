using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnYeetableCube : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject clone = Instantiate(prefab, transform.position, Quaternion.identity);
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 20, ForceMode.Impulse);
        }
    }
}
