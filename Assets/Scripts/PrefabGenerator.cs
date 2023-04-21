using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 firstPosition;
    public float gap = 2;

    void Start()
    {
        Vector3 position = firstPosition;
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, position, Quaternion.identity);
            position.x += gap;
            // Start is called before the first frame update
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key will generate a prefab at the 
        //position of the original prefab
        //Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
